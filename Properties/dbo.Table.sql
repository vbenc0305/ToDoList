CREATE TABLE Felhasznalo (
    [ID] INT IDENTITY(1,1) NOT NULL ,
    Vezeteknev VARCHAR(255) NOT NULL,
    Keresztnev VARCHAR(255) NOT NULL, 
    CONSTRAINT [Felhasznalo_id] PRIMARY KEY ([ID])
);
