CREATE DATABASE Finanzauto;
Go

USE [Finanzauto]
GO

CREATE TABLE [Roles](
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] VARCHAR(250) NOT NULL,
	[Remove] BIT NOT NULL DEFAULT 0,
);

INSERT INTO [Roles](
	[Name]
	)
	VALUES(
	'Admin'
	);

CREATE TABLE [Users](
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[UserName] VARCHAR(250) NOT NULL,
	[Password] VARCHAR(250) NOT NULL,
	[RoleId] INT NOT NULL,
	[Remove] BIT NOT NULL DEFAULT 0
);

INSERT INTO [Users](
	[UserName]
	,[Password]
	,[RoleId]
	)
	VALUES(
	'Admin'
	,'Test1234'
	,1
	);

CREATE TABLE [Students](
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] VARCHAR(250) NOT NULL,
	[LastName] VARCHAR(250) NOT NULL,
	[Identification] INT NOT NULL,
	[Email] VARCHAR(250) NULL,
	[PhoneNumber] VARCHAR(250) NULL,
	[Remove] BIT NOT NULL DEFAULT 0,
	[CreatedBy] INT NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedBy] INT NULL,
	[ModifiedOn] DATETIME NULL
);

CREATE TABLE [Teachers](
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] VARCHAR(250) NOT NULL,
	[LastName] VARCHAR(250) NOT NULL,
	[Email] VARCHAR(250) NULL,
	[PhoneNumber] VARCHAR(250) NULL,
	[Remove] BIT NOT NULL DEFAULT 0,
	[CreatedBy] INT NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedBy] INT NULL,
	[ModifiedOn] DATETIME NULL
);

CREATE TABLE [Courses](
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] VARCHAR(250) NOT NULL,
	[Remove] BIT NOT NULL DEFAULT 0,
	[CreatedBy] INT NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedBy] INT NULL,
	[ModifiedOn] DATETIME NULL
);

CREATE TABLE [Qualifications](
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Score] VARCHAR(250) NOT NULL,
	[CourseId] INT NOT NULL,
	[StudentId] INT NOT NULL,
	[TeacherId] INT NOT NULL,
	[Remove] BIT NOT NULL DEFAULT 0,
	[CreatedBy] INT NULL,
	[CreatedOn] DATETIME NULL,
	[ModifiedBy] INT NULL,
	[ModifiedOn] DATETIME NULL
);
