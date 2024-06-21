--USE master
--DROP DATABASE BDAcademia
CREATE DATABASE BDAcademia
GO
USE BDAcademia
GO
CREATE TABLE Aluno (
    IdAluno         INT IDENTITY CONSTRAINT PKAluno PRIMARY KEY,
    Nome            VARCHAR(50) NOT NULL,
    CPF             CHAR(14) NOT NULL CONSTRAINT UQCpf UNIQUE,
    Email           VARCHAR(70) NULL,
    Telefone        VARCHAR(14)
)
GO
CREATE TABLE Plano (
    IdPlano         INT IDENTITY CONSTRAINT PKPlano PRIMARY KEY,
    NomePlano       VARCHAR(100) NOT NULL,
    Preco           MONEY NOT NULL
)
GO
CREATE TABLE Matricula (
    IdMatricula     INT IDENTITY CONSTRAINT PKMatricula PRIMARY KEY,
    IdAluno         INT CONSTRAINT FKAluno FOREIGN KEY REFERENCES Aluno (IdAluno),
    IdPlano         INT CONSTRAINT FKPlano FOREIGN KEY REFERENCES Plano (IdPlano),
    DataMatricula   DATE NOT NULL,
    DataVencimento  DATE NOT NULL
)
GO
CREATE TABLE Usuario (
    IdUsuario       INT IDENTITY CONSTRAINT PKUsuario PRIMARY KEY,
    Nome            VARCHAR(MAX) NOT NULL,
    Email           VARCHAR(70) NOT NULL CONSTRAINT UQEmail UNIQUE,
    Senha           VARCHAR(40) NOT NULL,
    IsAdm           BIT DEFAULT 1
)
GO
INSERT INTO Usuario (Nome, Email, Senha, IsAdm) VALUES ('Administrador','admin@admin.com','admin',1)
GO

SELECT * FROM Usuario;
SELECT * FROM Aluno;
SELECT * FROM Plano;