IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200601143252_AddCarsToDB')
BEGIN
    CREATE TABLE [Cars] (
        [Id] int NOT NULL IDENTITY,
        [Marka] nvarchar(max) NOT NULL,
        [Model] nvarchar(max) NOT NULL,
        [Klasa] nvarchar(max) NULL,
        [PojSilnika] real NOT NULL,
        [Przebieg] float NOT NULL,
        [RokProd] datetime2 NOT NULL,
        [Paliwo] nvarchar(max) NULL,
        [Kolor] nvarchar(max) NULL,
        [Cena] int NOT NULL,
        [SmImage] varbinary(max) NULL,
        [BigImage] varbinary(max) NULL,
        CONSTRAINT [PK_Cars] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200601143252_AddCarsToDB')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200601143252_AddCarsToDB', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602164413_AddImageModel')
BEGIN
    CREATE TABLE [Images] (
        [ImageId] int NOT NULL IDENTITY,
        [Title] nvarchar(50) NULL,
        [ImageName] nvarchar(100) NULL,
        CONSTRAINT [PK_Images] PRIMARY KEY ([ImageId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602164413_AddImageModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200602164413_AddImageModel', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602171830_ChangeBookDbTable')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Cars]') AND [c].[name] = N'BigImage');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Cars] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Cars] DROP COLUMN [BigImage];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602171830_ChangeBookDbTable')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Cars]') AND [c].[name] = N'SmImage');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Cars] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Cars] DROP COLUMN [SmImage];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602171830_ChangeBookDbTable')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Images]') AND [c].[name] = N'ImageName');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Images] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Images] ALTER COLUMN [ImageName] nvarchar(100) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602171830_ChangeBookDbTable')
BEGIN
    ALTER TABLE [Cars] ADD [ImageName] nvarchar(100) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602171830_ChangeBookDbTable')
BEGIN
    ALTER TABLE [Cars] ADD [ImageTitle] nvarchar(50) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602171830_ChangeBookDbTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200602171830_ChangeBookDbTable', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602173400_ChangeBookDbTable2')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Cars]') AND [c].[name] = N'PojSilnika');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Cars] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Cars] ALTER COLUMN [PojSilnika] int NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200602173400_ChangeBookDbTable2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200602173400_ChangeBookDbTable2', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200603080710_AddOpisToCarModel')
BEGIN
    ALTER TABLE [Cars] ADD [Opis] nvarchar(200) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200603080710_AddOpisToCarModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200603080710_AddOpisToCarModel', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200603084610_AddOpisToCarModel2')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Cars]') AND [c].[name] = N'Opis');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Cars] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Cars] ALTER COLUMN [Opis] nvarchar(MAX) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200603084610_AddOpisToCarModel2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200603084610_AddOpisToCarModel2', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604104522_SeparCarAndImage')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Cars]') AND [c].[name] = N'ImageName');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Cars] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Cars] DROP COLUMN [ImageName];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604104522_SeparCarAndImage')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Cars]') AND [c].[name] = N'ImageTitle');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Cars] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Cars] DROP COLUMN [ImageTitle];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604104522_SeparCarAndImage')
BEGIN
    EXEC sp_rename N'[Images].[Title]', N'ImageTitle', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604104522_SeparCarAndImage')
BEGIN
    ALTER TABLE [Cars] ADD [CarimgIdImageId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604104522_SeparCarAndImage')
BEGIN
    CREATE INDEX [IX_Cars_CarimgIdImageId] ON [Cars] ([CarimgIdImageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604104522_SeparCarAndImage')
BEGIN
    ALTER TABLE [Cars] ADD CONSTRAINT [FK_Cars_Images_CarimgIdImageId] FOREIGN KEY ([CarimgIdImageId]) REFERENCES [Images] ([ImageId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604104522_SeparCarAndImage')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200604104522_SeparCarAndImage', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604105510_SeparCarAndImage2')
BEGIN
    ALTER TABLE [Cars] DROP CONSTRAINT [FK_Cars_Images_CarimgIdImageId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604105510_SeparCarAndImage2')
BEGIN
    EXEC sp_rename N'[Cars].[CarimgIdImageId]', N'CarImageImageId', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604105510_SeparCarAndImage2')
BEGIN
    EXEC sp_rename N'[Cars].[IX_Cars_CarimgIdImageId]', N'IX_Cars_CarImageImageId', N'INDEX';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604105510_SeparCarAndImage2')
BEGIN
    ALTER TABLE [Cars] ADD CONSTRAINT [FK_Cars_Images_CarImageImageId] FOREIGN KEY ([CarImageImageId]) REFERENCES [Images] ([ImageId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604105510_SeparCarAndImage2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200604105510_SeparCarAndImage2', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604160557_New_DB')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200604160557_New_DB', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200604180938_ContextEdit')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200604180938_ContextEdit', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200605194057_AddAfterWorkingModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200605194057_AddAfterWorkingModel', N'2.1.14-servicing-32113');
END;

GO

