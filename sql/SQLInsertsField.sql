INSERT INTO dbo.Student (
    Ime, Prezime, DatumRodjenja, BrojIndeksa, Telefon, Email, Ulica,
    BrojKuce, PTT, Grad, Zemlja, SmerId, JeAdministrator, PolID, KrisnikID
)
SELECT 
    Ime,
    Prezime,
    DatumRodjenja,
    BrojIndeksa,
    CAST(Telefon AS nvarchar(20)),
    Email,
    Ulica,
    CAST(BrojKuce AS nvarchar(10)),
    CAST(PTT AS nvarchar(10)),
    Grad,
    Zemlja,
    CASE 
        WHEN SmerID = 'i' THEN 1
        WHEN SmerID = 'u' THEN 2
        WHEN SmerID = 'e' THEN 3
        WHEN SmerID = 'p' THEN 4
        WHEN SmerID = 'm' THEN 5
        ELSE NULL
    END AS SmerId,
    CASE 
        WHEN JeAdministrator = 'TRUE' THEN 1
        WHEN JeAdministrator = 'FALSE' THEN 0
        ELSE 0
    END AS JeAdministrator,
    Pol,
    CASE 
        WHEN KorisnikID = 'NULL' THEN NULL
        ELSE TRY_CAST(KorisnikID AS int)
    END AS KrisnikID
FROM dbo.BazaStudenata;
