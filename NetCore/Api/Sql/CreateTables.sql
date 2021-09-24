-- Users
CREATE TABLE Users (
    Id BIGINT IDENTITY(1,1),
    Uuid UNIQUEIDENTIFIER DEFAULT NEWID(),
    Name VARCHAR(20) NOT NULL,
    Username VARCHAR(20) NOT NULL UNIQUE,
    Password VARCHAR(20) NOT NULL,
    CreatedBy VARCHAR(20),
    UpdatedBy VARCHAR(20),
    CreationDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdateDate DATETIME,
    FOREIGN KEY (CreatedBy) REFERENCES Users(Username),
    FOREIGN KEY (UpdatedBy) REFERENCES Users(Username),
    PRIMARY KEY (Id)
); GO

CREATE TRIGGER triggerUpdateDateUser 
ON dbo.Users AFTER UPDATE 
AS
   UPDATE dbo.Users 
   SET UpdateDate = CURRENT_TIMESTAMP 
   FROM Inserted i 
   WHERE dbo.Users.Id = i.Id;
