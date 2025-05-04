-- Base schema for EnvMonitorDb

-- 1. Create the database if it doesn’t exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'EnvMonitorDb')
BEGIN
    CREATE DATABASE EnvMonitorDb;
END;
GO

USE EnvMonitorDb;
GO

-- 2. Roles & Users

CREATE TABLE Roles (
    RoleId   INT IDENTITY(1,1) PRIMARY KEY,
    Name     NVARCHAR(50) NOT NULL UNIQUE
);
GO

CREATE TABLE Users (
    UserId       INT IDENTITY(1,1) PRIMARY KEY,
    Username     NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(256) NOT NULL,
    RoleId       INT NOT NULL
        CONSTRAINT FK_Users_Roles REFERENCES Roles(RoleId),
    IsLocked     BIT NOT NULL DEFAULT 0,
    LockoutEnd   DATETIME2 NULL,
    CreatedAt    DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);
GO

-- 3. Sensors

CREATE TABLE Sensors (
    SensorId         UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name             NVARCHAR(100) NOT NULL,
    Location         NVARCHAR(200) NULL,
    Status           NVARCHAR(20)  NOT NULL DEFAULT 'Active',
    LastHeartbeatUtc DATETIME2     NULL,
    CreatedAt        DATETIME2     NOT NULL DEFAULT SYSUTCDATETIME()
);
GO

-- 4. Air quality readings

CREATE TABLE AirReadings (
    ReadingId    INT IDENTITY(1,1) PRIMARY KEY,
    SensorId     UNIQUEIDENTIFIER NOT NULL
        CONSTRAINT FK_AirReadings_Sensors REFERENCES Sensors(SensorId),
    TimestampUtc DATETIME2 NOT NULL,
    PM25         FLOAT      NULL,
    NO2          FLOAT      NULL
);
GO

-- 5. Water quality readings

CREATE TABLE WaterReadings (
    ReadingId    INT IDENTITY(1,1) PRIMARY KEY,
    SensorId     UNIQUEIDENTIFIER NOT NULL
        CONSTRAINT FK_WaterReadings_Sensors REFERENCES Sensors(SensorId),
    TimestampUtc DATETIME2 NOT NULL,
    pH           FLOAT      NULL,
    Turbidity    FLOAT      NULL
);
GO

-- 6. Weather readings

CREATE TABLE WeatherReadings (
    ReadingId    INT IDENTITY(1,1) PRIMARY KEY,
    SensorId     UNIQUEIDENTIFIER NOT NULL
        CONSTRAINT FK_WeatherReadings_Sensors REFERENCES Sensors(SensorId),
    TimestampUtc DATETIME2 NOT NULL,
    Temperature  FLOAT      NULL,
    Humidity     FLOAT      NULL
);
GO
