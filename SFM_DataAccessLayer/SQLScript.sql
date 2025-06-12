CREATE DATABASE FacilityManagementDB;
GO

USE FacilityManagementDB;
GO

CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    
    PhoneNumber NVARCHAR(15),
    Department NVARCHAR(100),
    
    SecurityAnswer0 NVARCHAR(255) NOT NULL,
    SecurityAnswer1 NVARCHAR(255) NOT NULL
);
GO
INSERT INTO Users (UserName, Email, Password, PhoneNumber, Department, SecurityAnswer0, SecurityAnswer1)
VALUES
('Alice Johnson', 'alice.johnson@example.com', '123', '9876543210', 'IT Support', 'Blue', 'Sunday'),
('Bob Smith', 'bob.smith@example.com', '123', '9123456780', 'Maintenance', 'Yellow', 'Friday'),
('Carol Davis', 'carol.davis@example.com', '123', '9988776655', 'Administration', 'Red', 'Saturday');
GO

-- Check inserted data
SELECT * FROM Users;