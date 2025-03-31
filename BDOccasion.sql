DROP DATABASE IF EXISTS bdOccasion;
CREATE DATABASE IF NOT EXISTS bdOccasion;
USE bdOccasion;
CREATE TABLE IF NOT EXISTS Modele
(
	idModele int(3) AUTO_INCREMENT,
    libModele varchar(30),
    marque varchar(30),
    carburant enum('essence','diesel','gpl','électrique'),
    
    primary Key (idModele)
)

ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Voiture
(
	immat varchar(9),
    idModele int(3),
    nbPlaces enum('2','4','5','7'),
    datePremImmat timestamp,
    
    -- primary key (immat , idModele),
    foreign key (idModele) references Modele (idModele)
)

ENGINE=InnoDB;


CREATE TABLE IF NOT EXISTS Proprietaire
(
	idProp int(3) AUTO_INCREMENT,
    nom varchar(30),
    prenom varchar(30),
    adresse varchar(30),
    codepostal varchar(5),
    ville varchar(40),
    
    primary key (idProp)
)

ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS CarteGrise
(
	idProp int(3),
    immat varchar(9),
    dateCarte timestamp,
    
    foreign key (idProp) references Proprietaire (idProp)
)

ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Concessionnaires
(
	idConce int(3),
	ville varchar(30),
    nom varchar(30),
    codepostal varchar(30),
    
    primary key (idConce)
)

ENGINE=InnoDB;
    
    
    INSERT INTO `proprietaire`(`nom`, `prenom`, `adresse`, `codepostal`, `ville`) VALUES
('DURAND', 'Yves', '40 rue du Breuil', '63118', 'CEBAZAT'),
('DUPUY', 'Charles', '5 place de Jaude', '63000', 'CLERMONT'),
('DURAND', 'Bernard', '130 avenue Berthelot', '66500', 'ISSOIRE'),
('MERLE', 'Caroline', '85 rue du temple', '63000', 'CLERMONT'),
('GARDY', 'Sylvie', '10 rue du port', '63000', 'CLERMONT'),
('JOBALET', 'Pascal', '54 avenue de la liberté', '63500', 'ISSOIRE'),
('VAISSEL', 'Stéphane', '18 place de Jaude', '63000', 'CLERMONT'),
('VAITOLET', 'Sabine', '30 impasse du fort', '63200', 'RIOM'),
('VAITOLET', 'Jean', '30 impasse du fort', '63200', 'RIOM'),
('VAZEL', 'Pascal', '3 rue Zola', '63000', 'CLERMONT');

INSERT INTO Modele VALUES(1,'207','Peugeot','essence');
INSERT INTO Modele VALUES(2,'207','Peugeot','diesel');
INSERT INTO Modele VALUES(3,'308','Peugeot','essence');
INSERT INTO Modele VALUES(4,'308','Peugeot','diesel');
INSERT INTO Modele VALUES(5,'C2','Citroën','essence');
INSERT INTO Modele VALUES(6,'C2','Citroën','diesel');
INSERT INTO Modele VALUES(7,'C3 Picasso','Citroën','diesel');
INSERT INTO Modele VALUES(8,'A3','Audi','diesel');
INSERT INTO Modele VALUES(9,'A4','Audi','diesel');

INSERT INTO Voiture VALUES('BR-363-SJ',1,'5','2018-09-04');
INSERT INTO Voiture VALUES('SR-163-RJ',2,'5','2020-04-01');
INSERT INTO Voiture VALUES('BB-222-DE',2,'5','2022-10-01');
INSERT INTO Voiture VALUES('CV-789-XS',2,'5','2021-09-07');
INSERT INTO Voiture VALUES('SE-987-DD',4,'5','2020-01-01');
INSERT INTO Voiture VALUES('RT-578-CD',4,'5','2020-01-01');
INSERT INTO Voiture VALUES('CF-699-ZE',5,'4','2021-03-01');
INSERT INTO Voiture VALUES('AQ-748-UK',5,'4','2021-10-05');
INSERT INTO Voiture VALUES('TT-123-PM',6,'4','2016-12-10');
INSERT INTO Voiture VALUES('EY-745-NM',7,'5','2022-05-02');
INSERT INTO Voiture VALUES('AB-487-RE',7,'7','2022-04-20');
INSERT INTO Voiture VALUES('TB-652-OP',7,'7','2023-02-01');
INSERT INTO Voiture VALUES('FR-657-TX',8,'4','2023-01-05');
INSERT INTO Voiture VALUES('UI-325-FD',8,'4','2022-08-04');

INSERT INTO Cartegrise VALUES(1,'BR-363-SJ','2019-10-03');
INSERT INTO Cartegrise VALUES(1,'SR-163-RJ','2021-09-01');
INSERT INTO Cartegrise VALUES(1,'BB-222-DE','2023-01-31');
INSERT INTO Cartegrise VALUES(2,'TB-652-OP','2023-03-08');
INSERT INTO Cartegrise VALUES(3,'SE-987-DD','2021-05-01');
INSERT INTO Cartegrise VALUES(4,'RT-578-CD','2020-06-21');
INSERT INTO Cartegrise VALUES(4,'CF-699-ZE','2022-01-01');
INSERT INTO Cartegrise VALUES(4,'AQ-748-UK','2023-01-01');
INSERT INTO Cartegrise VALUES(5,'TT-123-PM','2019-09-22');
INSERT INTO Cartegrise VALUES(5,'EY-745-NM','2022-12-15');
INSERT INTO Cartegrise VALUES(6,'AB-487-RE','2022-10-25');
INSERT INTO Cartegrise VALUES(7,'CV-789-XS','2023-03-18');
INSERT INTO Cartegrise VALUES(8,'FR-657-TX','2023-03-10');
INSERT INTO Cartegrise VALUES(8,'UI-325-FD','2023-03-13');

INSERT INTO Concessionnaires VALUES(1,'ville','nom','code');
