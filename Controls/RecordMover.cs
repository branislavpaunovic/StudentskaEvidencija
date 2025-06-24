using System;
using System.Data;
using System.Data.SqlClient;

namespace StudentskaEvidencija.Controls
{
    public class RecordMover
    {
        private readonly string _connectionString;
        private readonly string _tableName;
        private readonly string _orderColumn;
        private readonly string _idColumn;

        public RecordMover(string connectionString, string tableName, string orderColumn, string idColumn)
        {
            _connectionString = connectionString;
            _tableName = tableName;
            _orderColumn = orderColumn;
            _idColumn = idColumn;
        }

        // Pomeri izabrani slog na početak baze (najmanji redosled)
        public void MoveToTop(int recordId)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Dohvati trenutni redosled slogova
                var currentOrder = GetOrder(conn, recordId);
                if (currentOrder == -1) return;

                // Dohvati minimalan redosled u tabeli
                var minOrder = GetMinOrder(conn);
                if (currentOrder == minOrder) return;

                using (var tran = conn.BeginTransaction())
                {
                    // Uvećaj redosled svim slogovima koji su ispred
                    var shiftCmd = new SqlCommand(
                        $"UPDATE [{_tableName}] SET [{_orderColumn}] = [{_orderColumn}] + 1 WHERE [{_orderColumn}] < @CurrentOrder",
                        conn, tran);
                    shiftCmd.Parameters.AddWithValue("@CurrentOrder", currentOrder);
                    shiftCmd.ExecuteNonQuery();

                    // Postavi trenutni slog na minimalnu poziciju
                    var moveCmd = new SqlCommand(
                        $"UPDATE [{_tableName}] SET [{_orderColumn}] = @MinOrder WHERE [{_idColumn}] = @Id",
                        conn, tran);
                    moveCmd.Parameters.AddWithValue("@MinOrder", minOrder);
                    moveCmd.Parameters.AddWithValue("@Id", recordId);
                    moveCmd.ExecuteNonQuery();

                    tran.Commit();
                }
            }
        }

        // Pomeri izabrani slog jedan red iznad
        public void MoveUp(int recordId)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var currentOrder = GetOrder(conn, recordId);
                if (currentOrder == -1) return;

                // Pronađi prethodni slog
                int prevId = -1, prevOrder = -1;
                using (var cmd = new SqlCommand(
                    $"SELECT TOP 1 [{_idColumn}], [{_orderColumn}] FROM [{_tableName}] " +
                    $"WHERE [{_orderColumn}] < @Order ORDER BY [{_orderColumn}] DESC", conn))
                {
                    cmd.Parameters.AddWithValue("@Order", currentOrder);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            prevId = reader.GetInt32(0);
                            prevOrder = reader.GetInt32(1);
                        }
                    }
                }

                if (prevId == -1) return;

                // Zamena redosleda sa prethodnim slogom
                SwapOrders(conn, recordId, currentOrder, prevId, prevOrder);
            }
        }

        // Pomeri izabrani slog jedan red ispod
        public void MoveDown(int recordId)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var currentOrder = GetOrder(conn, recordId);
                if (currentOrder == -1) return;

                // Pronađi sledeći slog
                int nextId = -1, nextOrder = -1;
                using (var cmd = new SqlCommand(
                    $"SELECT TOP 1 [{_idColumn}], [{_orderColumn}] FROM [{_tableName}] " +
                    $"WHERE [{_orderColumn}] > @Order ORDER BY [{_orderColumn}] ASC", conn))
                {
                    cmd.Parameters.AddWithValue("@Order", currentOrder);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nextId = reader.GetInt32(0);
                            nextOrder = reader.GetInt32(1);
                        }
                    }
                }

                if (nextId == -1) return;

                // Zamena redosleda sa sledećim slogom
                SwapOrders(conn, recordId, currentOrder, nextId, nextOrder);
            }
        }

        // Pomeri izabrani slog na kraj baze (najveći redosled)
        public void MoveToBottom(int recordId)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                var currentOrder = GetOrder(conn, recordId);
                if (currentOrder == -1) return;

                var maxOrder = GetMaxOrder(conn);
                if (currentOrder == maxOrder) return;

                using (var tran = conn.BeginTransaction())
                {
                    // Smanji redosled za 1 svima koji su iza trenutnog
                    var cmd1 = new SqlCommand(
                        $"UPDATE [{_tableName}] SET [{_orderColumn}] = [{_orderColumn}] - 1 WHERE [{_orderColumn}] > @CurrentOrder",
                        conn, tran);
                    cmd1.Parameters.AddWithValue("@CurrentOrder", currentOrder);
                    cmd1.ExecuteNonQuery();

                    // Postavi trenutni slog kao poslednji
                    var cmd2 = new SqlCommand(
                        $"UPDATE [{_tableName}] SET [{_orderColumn}] = @MaxOrder WHERE [{_idColumn}] = @Id",
                        conn, tran);
                    cmd2.Parameters.AddWithValue("@MaxOrder", maxOrder);
                    cmd2.Parameters.AddWithValue("@Id", recordId);
                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                }
            }
        }

        // Pomoćne metode:

        // Dohvata trenutni redosled za dati ID
        private int GetOrder(SqlConnection conn, int id)
        {
            using (var cmd = new SqlCommand(
                $"SELECT [{_orderColumn}] FROM [{_tableName}] WHERE [{_idColumn}] = @Id", conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                var result = cmd.ExecuteScalar();
                return result == null ? -1 : Convert.ToInt32(result);
            }
        }

        // Dohvata minimalnu vrednost redosleda
        private int GetMinOrder(SqlConnection conn)
        {
            using (var cmd = new SqlCommand(
                $"SELECT MIN([{_orderColumn}]) FROM [{_tableName}]", conn))
            {
                var result = cmd.ExecuteScalar();
                return result == null ? -1 : Convert.ToInt32(result);
            }
        }

        // Dohvata maksimalnu vrednost redosleda
        private int GetMaxOrder(SqlConnection conn)
        {
            using (var cmd = new SqlCommand(
                $"SELECT MAX([{_orderColumn}]) FROM [{_tableName}]", conn))
            {
                var result = cmd.ExecuteScalar();
                return result == null ? -1 : Convert.ToInt32(result);
            }
        }

        // Menja mesta redosledima između dva slogova
        private void SwapOrders(SqlConnection conn, int id1, int order1, int id2, int order2)
        {
            using (var tran = conn.BeginTransaction())
            {
                var cmd1 = new SqlCommand(
                    $"UPDATE [{_tableName}] SET [{_orderColumn}] = @Order WHERE [{_idColumn}] = @Id", conn, tran);
                cmd1.Parameters.AddWithValue("@Order", order2);
                cmd1.Parameters.AddWithValue("@Id", id1);
                cmd1.ExecuteNonQuery();

                var cmd2 = new SqlCommand(
                    $"UPDATE [{_tableName}] SET [{_orderColumn}] = @Order WHERE [{_idColumn}] = @Id", conn, tran);
                cmd2.Parameters.AddWithValue("@Order", order1);
                cmd2.Parameters.AddWithValue("@Id", id2);
                cmd2.ExecuteNonQuery();

                tran.Commit();
            }
        }
    }
}