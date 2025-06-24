using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentskaEvidencija.Controls
{
    public class RecordNavigator
    {
        private readonly string _connectionString;
        private readonly string _tableName;
        private DataTable _data;
        private int _currentIndex = 0;
        private Control[] _boundControls;
        private string[] _columnNames;

        public RecordNavigator(string connectionString, string tableName)
        {
            _connectionString = connectionString;
            _tableName = tableName;
            LoadData();
        }

        private void LoadData()
        {
            using (var conn = new SqlConnection(_connectionString))
            using (var da = new SqlDataAdapter($"SELECT * FROM [{_tableName}]", conn))
            {
                _data = new DataTable();
                da.Fill(_data);
            }
        }

        // Poveži kontrole sa kolonama (redosled mora odgovarati)
        public void BindControls(Control[] controls, string[] columnNames)
        {
            _boundControls = controls;
            _columnNames = columnNames;
            ShowCurrent();
        }

        public void MoveFirst()
        {
            _currentIndex = 0;
            ShowCurrent();
        }

        public void MovePrevious()
        {
            if (_currentIndex > 0) _currentIndex--;
            ShowCurrent();
        }

        public void MoveNext()
        {
            if (_currentIndex < _data.Rows.Count - 1) _currentIndex++;
            ShowCurrent();
        }

        public void MoveLast()
        {
            _currentIndex = _data.Rows.Count - 1;
            ShowCurrent();
        }

        private void ShowCurrent()
        {
            if (_data.Rows.Count == 0 || _boundControls == null) return;
            var row = _data.Rows[_currentIndex];
            for (int i = 0; i < _boundControls.Length; i++)
            {
                if (_boundControls[i] is TextBox tb)
                    tb.Text = row[_columnNames[i]].ToString();
                // Dodaj podršku za druge kontrole po potrebi
            }
        }
    }
}
