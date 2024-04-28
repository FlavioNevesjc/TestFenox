-- Flávio Soares Neves
-- Teste Fenox

-- Criar o banco de dados
CREATE DATABASE DBFenox;

-- criando as tabelas do DBFenox

CREATE TABLE Fuel
(IdFuel INT IDENTITY PRIMARY KEY NOT NULL, DescriptionFuel VARCHAR(50) NOT NULL, StatusFuel INT NOT NULL);

CREATE TABLE Color
(IdColor INT IDENTITY PRIMARY KEY NOT NULL , DescriptionColor VARCHAR(50) NOT NULL, StatusColor INT NOT NULL);

CREATE TABLE Vehicle
(IdVehicle INT IDENTITY PRIMARY KEY NOT NULL, Plate VARCHAR(7) NOT NULL, Renavan VARCHAR(11) NOT NULL,
 ChassisNumber VARCHAR(17) NOT NULL, EngineNumber VARCHAR(17) NOT NULL, Brand VARCHAR(50) NOT NULL,
 Model VARCHAR (70) NOT NULL, FuelId_F INT, ColorId_F INT, YearOfManufacture VARCHAR(4), StatusVehicle INT NOT NULL);

-- criando chaves estrangeiras

ALTER TABLE Vehicle ADD CONSTRAINT Fk_FuelId_F FOREIGN KEY(FuelId_F) REFERENCES Fuel (IdFuel);
ALTER TABLE Vehicle ADD CONSTRAINT Fk_ColorId_F FOREIGN KEY(ColorId_F) REFERENCES Color (IdColor);