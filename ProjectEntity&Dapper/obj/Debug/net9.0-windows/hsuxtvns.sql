IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [Customer] (
    [Id] int NOT NULL IDENTITY,
    [Code] int NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [Adress] nvarchar(max) NOT NULL,
    [Note] nvarchar(max) NOT NULL,
    [Company] nvarchar(max) NOT NULL,
    [Email] nvarchar(50) NOT NULL,
    [PhoneNumber] nvarchar(50) NOT NULL,
    [isActive] bit NOT NULL,
    [Image] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY ([Id])
);

CREATE TABLE [Products] (
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(50) NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [Price] decimal(18,2) NOT NULL,
    [Quatity] int NOT NULL,
    [Note] nvarchar(max) NOT NULL,
    [Image] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
);

CREATE TABLE [Supplier] (
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(50) NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [Adress] nvarchar(max) NOT NULL,
    [Note] nvarchar(max) NOT NULL,
    [Company] nvarchar(max) NOT NULL,
    [Email] nvarchar(50) NOT NULL,
    [PhoneNumber] nvarchar(50) NOT NULL,
    [isActive] bit NOT NULL,
    [Image] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Supplier] PRIMARY KEY ([Id])
);

CREATE TABLE [User] (
    [Id] int NOT NULL IDENTITY,
    [Email] nvarchar(50) NOT NULL,
    [Password] nvarchar(50) NOT NULL,
    [UserName] nvarchar(50) NOT NULL,
    [Adress] nvarchar(250) NOT NULL,
    [Image] nvarchar(max) NOT NULL,
    [Birthday] datetime2 NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250124092804_v1', N'9.0.1');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250124093359_v2', N'9.0.1');

DECLARE @var sysname;
SELECT @var = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[User]') AND [c].[name] = N'Image');
IF @var IS NOT NULL EXEC(N'ALTER TABLE [User] DROP CONSTRAINT [' + @var + '];');
ALTER TABLE [User] ALTER COLUMN [Image] nvarchar(max) NULL;

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[User]') AND [c].[name] = N'Email');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [User] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [User] ALTER COLUMN [Email] nvarchar(50) NULL;

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[User]') AND [c].[name] = N'Birthday');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [User] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [User] ALTER COLUMN [Birthday] datetime2 NULL;

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[User]') AND [c].[name] = N'Adress');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [User] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [User] ALTER COLUMN [Adress] nvarchar(250) NULL;

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Supplier]') AND [c].[name] = N'isActive');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Supplier] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Supplier] ALTER COLUMN [isActive] bit NULL;

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Supplier]') AND [c].[name] = N'PhoneNumber');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Supplier] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Supplier] ALTER COLUMN [PhoneNumber] nvarchar(50) NULL;

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Supplier]') AND [c].[name] = N'Note');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Supplier] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Supplier] ALTER COLUMN [Note] nvarchar(max) NULL;

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Supplier]') AND [c].[name] = N'Image');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Supplier] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Supplier] ALTER COLUMN [Image] nvarchar(max) NULL;

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Supplier]') AND [c].[name] = N'Email');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Supplier] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Supplier] ALTER COLUMN [Email] nvarchar(50) NULL;

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'Note');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Products] ALTER COLUMN [Note] nvarchar(max) NULL;

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'Name');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [Products] ALTER COLUMN [Name] nvarchar(50) NULL;

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'Image');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [Products] ALTER COLUMN [Image] nvarchar(max) NULL;

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'isActive');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [Customer] ALTER COLUMN [isActive] bit NULL;

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'PhoneNumber');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [Customer] ALTER COLUMN [PhoneNumber] nvarchar(50) NULL;

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'Note');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [Customer] ALTER COLUMN [Note] nvarchar(max) NULL;

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'Image');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [Customer] ALTER COLUMN [Image] nvarchar(max) NULL;

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'Email');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [Customer] ALTER COLUMN [Email] nvarchar(50) NULL;

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'Company');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [Customer] ALTER COLUMN [Company] nvarchar(max) NULL;

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'Adress');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [Customer] ALTER COLUMN [Adress] nvarchar(max) NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250124112438_v3', N'9.0.1');

ALTER TABLE [Products] ADD [catid] int NOT NULL DEFAULT 0;

CREATE TABLE [Category] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([Id])
);

CREATE INDEX [IX_Products_catid] ON [Products] ([catid]);

ALTER TABLE [Products] ADD CONSTRAINT [FK_Products_Category_catid] FOREIGN KEY ([catid]) REFERENCES [Category] ([Id]) ON DELETE CASCADE;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250124195029_v4', N'9.0.1');

ALTER TABLE [User] ADD [Role] nvarchar(50) NULL;

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'Name');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var19 + '];');
UPDATE [Products] SET [Name] = N'' WHERE [Name] IS NULL;
ALTER TABLE [Products] ALTER COLUMN [Name] nvarchar(50) NOT NULL;
ALTER TABLE [Products] ADD DEFAULT N'' FOR [Name];

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250126193847_v5', N'9.0.1');

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'Adress');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [Customer] DROP COLUMN [Adress];

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'Code');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [Customer] DROP COLUMN [Code];

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'Company');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [Customer] DROP COLUMN [Company];

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'Image');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [Customer] DROP COLUMN [Image];

EXEC sp_rename N'[Customer].[Note]', N'Notes', 'COLUMN';

EXEC sp_rename N'[Customer].[Name]', N'CustomerName', 'COLUMN';

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customer]') AND [c].[name] = N'PhoneNumber');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [Customer] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [Customer] ALTER COLUMN [PhoneNumber] nvarchar(15) NULL;

ALTER TABLE [Customer] ADD [Address] nvarchar(250) NULL;

ALTER TABLE [Customer] ADD [City] nvarchar(50) NULL;

ALTER TABLE [Customer] ADD [Country] nvarchar(50) NULL;

CREATE UNIQUE INDEX [IX_Customer_Email] ON [Customer] ([Email]) WHERE [Email] IS NOT NULL;

CREATE UNIQUE INDEX [IX_Customer_PhoneNumber] ON [Customer] ([PhoneNumber]) WHERE [PhoneNumber] IS NOT NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250128164701_v6', N'9.0.1');

CREATE TABLE [Invoices] (
    [InvoiceId] int NOT NULL IDENTITY,
    [InvoiceDate] datetime2 NOT NULL,
    [Notes] nvarchar(250) NULL,
    [TotalAmount] decimal(18,2) NOT NULL,
    [CustomerId] int NOT NULL,
    CONSTRAINT [PK_Invoices] PRIMARY KEY ([InvoiceId]),
    CONSTRAINT [FK_Invoices_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [InvoiceDetails] (
    [InvoiceDetailId] int NOT NULL IDENTITY,
    [Quantity] int NOT NULL,
    [UnitPrice] decimal(18,2) NOT NULL,
    [InvoiceId] int NOT NULL,
    [ProductId] int NOT NULL,
    CONSTRAINT [PK_InvoiceDetails] PRIMARY KEY ([InvoiceDetailId]),
    CONSTRAINT [FK_InvoiceDetails_Invoices_InvoiceId] FOREIGN KEY ([InvoiceId]) REFERENCES [Invoices] ([InvoiceId]) ON DELETE CASCADE,
    CONSTRAINT [FK_InvoiceDetails_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE CASCADE
);

CREATE INDEX [IX_InvoiceDetails_InvoiceId] ON [InvoiceDetails] ([InvoiceId]);

CREATE INDEX [IX_InvoiceDetails_ProductId] ON [InvoiceDetails] ([ProductId]);

CREATE INDEX [IX_Invoices_CustomerId] ON [Invoices] ([CustomerId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250128195958_v7', N'9.0.1');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250129205505_v8', N'9.0.1');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250129210011_v9', N'9.0.1');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250129210135_v10', N'9.0.1');

COMMIT;
GO

