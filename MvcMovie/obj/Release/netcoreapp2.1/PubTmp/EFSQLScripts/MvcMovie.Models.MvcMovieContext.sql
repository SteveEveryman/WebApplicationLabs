IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181109213434_review')
BEGIN
    CREATE TABLE [Movie] (
        [ID] int NOT NULL IDENTITY,
        [Title] nvarchar(60) NOT NULL,
        [ReleaseDate] datetime2 NOT NULL,
        [Price] decimal(18, 2) NOT NULL,
        [Genre] nvarchar(30) NOT NULL,
        [Rating] nvarchar(max) NOT NULL,
        [PosterURL] nvarchar(max) NULL,
        CONSTRAINT [PK_Movie] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181109213434_review')
BEGIN
    CREATE TABLE [Review] (
        [ID] int NOT NULL IDENTITY,
        [Reviewer] nvarchar(60) NOT NULL,
        [UserReview] nvarchar(1500) NOT NULL,
        [MovieID] int NOT NULL,
        [MovieTitle] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Review] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181109213434_review')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181109213434_review', N'2.1.3-rtm-32065');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181109221919_final')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181109221919_final', N'2.1.3-rtm-32065');
END;

GO

