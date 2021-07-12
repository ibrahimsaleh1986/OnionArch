﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711143213_Initial')
BEGIN
    CREATE TABLE [TaskItems] (
        [Id] int NOT NULL IDENTITY,
        [TaskName] nvarchar(255) NOT NULL,
        [IsCompleted] bit NOT NULL,
        [DateCreated] datetime2 NOT NULL,
        [LastModified] datetime2 NOT NULL,
        [CreatedById] nvarchar(255) NULL,
        [ModifiedById] nvarchar(255) NULL,
        [IsDeleted] bit NOT NULL,
        CONSTRAINT [PK_TaskItems] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711143213_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210711143213_Initial', N'5.0.7');
END;
GO

COMMIT;
GO

