-- Ako već postoji, možeš obrisati (OPREZ!)
-- DROP DATABASE StudentskaEvidencija;

-- 1. KREIRANJE BAZE
-- CREATE DATABASE StudentskaEvidencija
-- COLLATE Serbian_Latin_100_CI_AI;
-- GO

USE StudentskaEvidencija;
GO

-- 2. TABELA: Smer
CREATE TABLE Smer (
    SmerId INT IDENTITY(1,1) PRIMARY KEY,
    NazivSmera NVARCHAR(100) NOT NULL UNIQUE
);
GO

-- 3. TABELA: Korisnik (admini i obični korisnici sistema)
CREATE TABLE Korisnik (
    KorisnikId INT IDENTITY(1,1) PRIMARY KEY,
    Ime NVARCHAR(50) NOT NULL,
    Prezime NVARCHAR(50) NOT NULL,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Lozinka NVARCHAR(100) NOT NULL,
    IsAdmin BIT NOT NULL DEFAULT 0
);
GO

-- 4. TABELA: Student
CREATE TABLE Student (
    StudentId INT IDENTITY(1,1) PRIMARY KEY,

    -- Lični podaci
    Ime NVARCHAR(50) NOT NULL,
    Prezime NVARCHAR(50) NOT NULL,
    DatumRodjenja DATE NOT NULL,
    BrojIndeksa NVARCHAR(20) NOT NULL UNIQUE,

    -- Kontakt i adresa
    Telefon NVARCHAR(20),
    Email NVARCHAR(100),
    Ulica NVARCHAR(100),
    BrojKuce NVARCHAR(10),
    PTT NVARCHAR(10),
    Grad NVARCHAR(50),
    Zemlja NVARCHAR(50),

    -- Strana veza na Smer
    SmerId INT NOT NULL,

    -- Da li student ima administratorska prava
    JeAdministrator BIT NOT NULL DEFAULT 0,

    -- Foreign key
    CONSTRAINT FK_Student_Smer FOREIGN KEY (SmerId)
        REFERENCES Smer(SmerId)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
GO

-- 5. INDEKSI ZA OPTIMIZACIJU
-- Brža pretraga po prezimenu
CREATE INDEX IX_Student_Prezime ON Student(Prezime);

-- Jedinstven broj indeksa
CREATE UNIQUE INDEX UX_Student_BrojIndeksa ON Student(BrojIndeksa);
GO
