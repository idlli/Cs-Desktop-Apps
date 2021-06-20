CREATE DATABASE GestionCommercial

USE GestionCommercial

CREATE TABLE Client
	(
		CodeCl NVARCHAR (20) PRIMARY KEY,
		Nom NVARCHAR (50) NOT NULL,
		Ville NVARCHAR (50) NULL
	)

CREATE TABLE Commande 
	(
		NumCom NVARCHAR (20) PRIMARY KEY,
		DateCom DATETIME NULL,
		CodeCl NVARCHAR (20) FOREIGN KEY REFERENCES Client (CodeCl),
		NE BIT NULL DEFAULT 0
	)

CREATE TABLE Article
	(
		CodeArt NVARCHAR (50) PRIMARY KEY,
		Desi NVARCHAR (50) NULL,
		PU DECIMAL (6, 2) NULL,
		QDISP INT NULL
	)

CREATE TABLE Detail
	(
		NumCom NVARCHAR (20) FOREIGN KEY REFERENCES Commande (NumCom),
		CodeArt NVARCHAR (50) FOREIGN KEY REFERENCES Article (CodeArt),
		Qte INT NULL,
		PRIMARY KEY (NumCom, CodeArt)
	)

CREATE TABLE Livraison
	(
		NumLiv NVARCHAR (50) PRIMARY KEY,
		DateLiv DATE NULL,
		Livreur NVARCHAR (20) NULL,
		EtatLiv BIT NULL,
		NumCom NVARCHAR (20) FOREIGN KEY REFERENCES Commande (NumCom)
	)

CREATE TABLE LigneLivraison
	(
		NumLiv NVARCHAR (50) FOREIGN KEY REFERENCES Livraison (NumLiv),
		CodeArt NVARCHAR (50) FOREIGN KEY REFERENCES Article (CodeArt),
		QLiv INT NULL,
		PRIMARY KEY (NumLiv, CodeArt)
	)