IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [AspNetRoles] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Classes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Classes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] uniqueidentifier NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] uniqueidentifier NOT NULL,
    [RoleId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] uniqueidentifier NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey])
);

GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] uniqueidentifier NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name])
);

GO

CREATE TABLE [Attendances] (
    [Id] int NOT NULL IDENTITY,
    [StudentId] uniqueidentifier NOT NULL,
    [Date] datetime2 NOT NULL,
    [Present] bit NOT NULL,
    CONSTRAINT [PK_Attendances] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Departments] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [DepartmentHeadId] uniqueidentifier NULL,
    CONSTRAINT [PK_Departments] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetUsers] (
    [Id] uniqueidentifier NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    [FirstName] nvarchar(max) NOT NULL,
    [MiddleName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NULL,
    [Address] nvarchar(max) NOT NULL,
    [ProfileImage] varbinary(max) NULL,
    [Discriminator] nvarchar(max) NOT NULL,
    [AdmissionDate] datetime2 NULL,
    [DOB] datetime2 NULL,
    [ClassId] int NULL,
    [DepartmentId] int NULL,
    [ParentId] uniqueidentifier NULL,
    [EmploymentDate] datetime2 NULL,
    [Teacher_DOB] datetime2 NULL,
    [Teacher_ClassId] int NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUsers_Classes_ClassId] FOREIGN KEY ([ClassId]) REFERENCES [Classes] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_AspNetUsers_Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments] ([Id]) ON DELETE SET NULL,
    CONSTRAINT [FK_AspNetUsers_AspNetUsers_ParentId] FOREIGN KEY ([ParentId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_AspNetUsers_Classes_Teacher_ClassId] FOREIGN KEY ([Teacher_ClassId]) REFERENCES [Classes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Subjects] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [TeacherId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Subjects] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Subjects_AspNetUsers_TeacherId] FOREIGN KEY ([TeacherId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);

GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;

GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);

GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);

GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;

GO

CREATE INDEX [IX_AspNetUsers_ClassId] ON [AspNetUsers] ([ClassId]);

GO

CREATE INDEX [IX_AspNetUsers_DepartmentId] ON [AspNetUsers] ([DepartmentId]);

GO

CREATE INDEX [IX_AspNetUsers_ParentId] ON [AspNetUsers] ([ParentId]);

GO

CREATE INDEX [IX_AspNetUsers_Teacher_ClassId] ON [AspNetUsers] ([Teacher_ClassId]);

GO

CREATE INDEX [IX_Attendances_StudentId] ON [Attendances] ([StudentId]);

GO

CREATE UNIQUE INDEX [IX_Departments_DepartmentHeadId] ON [Departments] ([DepartmentHeadId]) WHERE [DepartmentHeadId] IS NOT NULL;

GO

CREATE INDEX [IX_Subjects_TeacherId] ON [Subjects] ([TeacherId]);

GO

ALTER TABLE [AspNetUserRoles] ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [AspNetUserClaims] ADD CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [AspNetUserLogins] ADD CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [AspNetUserTokens] ADD CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [Attendances] ADD CONSTRAINT [FK_Attendances_AspNetUsers_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [Departments] ADD CONSTRAINT [FK_Departments_AspNetUsers_DepartmentHeadId] FOREIGN KEY ([DepartmentHeadId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191112151939_Initial', N'2.2.3-servicing-35854');

GO

ALTER TABLE [Subjects] DROP CONSTRAINT [FK_Subjects_AspNetUsers_TeacherId];

GO

DROP INDEX [IX_Subjects_TeacherId] ON [Subjects];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Subjects]') AND [c].[name] = N'TeacherId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Subjects] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Subjects] DROP COLUMN [TeacherId];

GO

CREATE TABLE [DepartmentSubject] (
    [DepartmentId] int NOT NULL,
    [SubjectId] int NOT NULL,
    [Id] int NOT NULL,
    CONSTRAINT [PK_DepartmentSubject] PRIMARY KEY ([DepartmentId], [SubjectId]),
    CONSTRAINT [FK_DepartmentSubject_Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_DepartmentSubject_Subjects_SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [Subjects] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_DepartmentSubject_SubjectId] ON [DepartmentSubject] ([SubjectId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191113150812_AddedDepartmentSubject', N'2.2.3-servicing-35854');

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DepartmentSubject]') AND [c].[name] = N'Id');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [DepartmentSubject] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [DepartmentSubject] DROP COLUMN [Id];

GO

CREATE TABLE [AcademicSecion] (
    [Id] int NOT NULL IDENTITY,
    [BeginDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    CONSTRAINT [PK_AcademicSecion] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Exam] (
    [StudentId] uniqueidentifier NOT NULL,
    [DepartmentSubjectDepartmentId] int NOT NULL,
    [DepartmentSubjectSubjecttId] int NOT NULL,
    [AcademicSectionId] int NOT NULL,
    [Score] int NOT NULL,
    CONSTRAINT [PK_Exam] PRIMARY KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjecttId], [StudentId], [AcademicSectionId]),
    CONSTRAINT [FK_Exam_AcademicSecion_AcademicSectionId] FOREIGN KEY ([AcademicSectionId]) REFERENCES [AcademicSecion] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Exam_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId] FOREIGN KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjecttId]) REFERENCES [DepartmentSubject] ([DepartmentId], [SubjectId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Exam_AcademicSectionId] ON [Exam] ([AcademicSectionId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191114191217_Add-Exam-and-Test', N'2.2.3-servicing-35854');

GO

ALTER TABLE [Exam] DROP CONSTRAINT [FK_Exam_AcademicSecion_AcademicSectionId];

GO

ALTER TABLE [Exam] DROP CONSTRAINT [FK_Exam_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId];

GO

DROP TABLE [AcademicSecion];

GO

ALTER TABLE [Exam] DROP CONSTRAINT [PK_Exam];

GO

EXEC sp_rename N'[Exam]', N'Exams';

GO

EXEC sp_rename N'[Exams].[IX_Exam_AcademicSectionId]', N'IX_Exams_AcademicSectionId', N'INDEX';

GO

ALTER TABLE [Exams] ADD CONSTRAINT [PK_Exams] PRIMARY KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjecttId], [StudentId], [AcademicSectionId]);

GO

CREATE TABLE [AcademicSections] (
    [Id] int NOT NULL IDENTITY,
    [BeginDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    CONSTRAINT [PK_AcademicSections] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Tests] (
    [Id] int NOT NULL IDENTITY,
    [StudentId] uniqueidentifier NOT NULL,
    [DepartmentSubjectId] int NOT NULL,
    [DepartmentSubjectDepartmentId] int NULL,
    [DepartmentSubjectSubjectId] int NULL,
    [AcademicSection] int NOT NULL,
    [AcademicSecionId] int NULL,
    [Score] int NOT NULL,
    CONSTRAINT [PK_Tests] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Tests_AcademicSections_AcademicSecionId] FOREIGN KEY ([AcademicSecionId]) REFERENCES [AcademicSections] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId] FOREIGN KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjectId]) REFERENCES [DepartmentSubject] ([DepartmentId], [SubjectId]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Tests_AcademicSecionId] ON [Tests] ([AcademicSecionId]);

GO

CREATE INDEX [IX_Tests_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId] ON [Tests] ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjectId]);

GO

ALTER TABLE [Exams] ADD CONSTRAINT [FK_Exams_AcademicSections_AcademicSectionId] FOREIGN KEY ([AcademicSectionId]) REFERENCES [AcademicSections] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [Exams] ADD CONSTRAINT [FK_Exams_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId] FOREIGN KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjecttId]) REFERENCES [DepartmentSubject] ([DepartmentId], [SubjectId]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191117234130_Fixed-typo-Academicsection-Inseadof-AcademicSection', N'2.2.3-servicing-35854');

GO

ALTER TABLE [Exams] DROP CONSTRAINT [FK_Exams_AcademicSections_AcademicSectionId];

GO

ALTER TABLE [Tests] DROP CONSTRAINT [FK_Tests_AcademicSections_AcademicSecionId];

GO

DROP INDEX [IX_Tests_AcademicSecionId] ON [Tests];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tests]') AND [c].[name] = N'AcademicSecionId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Tests] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Tests] DROP COLUMN [AcademicSecionId];

GO

EXEC sp_rename N'[Tests].[AcademicSection]', N'TermId', N'COLUMN';

GO

EXEC sp_rename N'[Exams].[AcademicSectionId]', N'TermId', N'COLUMN';

GO

EXEC sp_rename N'[Exams].[IX_Exams_AcademicSectionId]', N'IX_Exams_TermId', N'INDEX';

GO

ALTER TABLE [AcademicSections] ADD [Term1Id] int NULL;

GO

ALTER TABLE [AcademicSections] ADD [Term2Id] int NULL;

GO

ALTER TABLE [AcademicSections] ADD [Term3Id] int NULL;

GO

ALTER TABLE [AcademicSections] ADD [TermId1] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [AcademicSections] ADD [TermId2] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [AcademicSections] ADD [TermId3] int NOT NULL DEFAULT 0;

GO

CREATE TABLE [Term] (
    [Id] int NOT NULL IDENTITY,
    CONSTRAINT [PK_Term] PRIMARY KEY ([Id])
);

GO

CREATE INDEX [IX_Tests_TermId] ON [Tests] ([TermId]);

GO

CREATE INDEX [IX_AcademicSections_Term1Id] ON [AcademicSections] ([Term1Id]);

GO

CREATE INDEX [IX_AcademicSections_Term2Id] ON [AcademicSections] ([Term2Id]);

GO

CREATE INDEX [IX_AcademicSections_Term3Id] ON [AcademicSections] ([Term3Id]);

GO

ALTER TABLE [AcademicSections] ADD CONSTRAINT [FK_AcademicSections_Term_Term1Id] FOREIGN KEY ([Term1Id]) REFERENCES [Term] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [AcademicSections] ADD CONSTRAINT [FK_AcademicSections_Term_Term2Id] FOREIGN KEY ([Term2Id]) REFERENCES [Term] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [AcademicSections] ADD CONSTRAINT [FK_AcademicSections_Term_Term3Id] FOREIGN KEY ([Term3Id]) REFERENCES [Term] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [Exams] ADD CONSTRAINT [FK_Exams_Term_TermId] FOREIGN KEY ([TermId]) REFERENCES [Term] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [Tests] ADD CONSTRAINT [FK_Tests_Term_TermId] FOREIGN KEY ([TermId]) REFERENCES [Term] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191118175336_AddTerm', N'2.2.3-servicing-35854');

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AcademicSections]') AND [c].[name] = N'TermId1');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [AcademicSections] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [AcademicSections] DROP COLUMN [TermId1];

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AcademicSections]') AND [c].[name] = N'TermId2');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [AcademicSections] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [AcademicSections] DROP COLUMN [TermId2];

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AcademicSections]') AND [c].[name] = N'TermId3');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [AcademicSections] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [AcademicSections] DROP COLUMN [TermId3];

GO

ALTER TABLE [Term] ADD [EndDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [Term] ADD [StartDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191118185546_Fix-AcademicSestion-typo', N'2.2.3-servicing-35854');

GO

ALTER TABLE [Tests] DROP CONSTRAINT [FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId];

GO

ALTER TABLE [Tests] DROP CONSTRAINT [PK_Tests];

GO

DROP INDEX [IX_Tests_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId] ON [Tests];

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tests]') AND [c].[name] = N'Id');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Tests] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Tests] DROP COLUMN [Id];

GO

EXEC sp_rename N'[Tests].[DepartmentSubjectId]', N'DepartmentSubjectSubjecttId', N'COLUMN';

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tests]') AND [c].[name] = N'DepartmentSubjectSubjectId');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Tests] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Tests] ALTER COLUMN [DepartmentSubjectSubjectId] int NOT NULL;

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tests]') AND [c].[name] = N'DepartmentSubjectDepartmentId');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Tests] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Tests] ALTER COLUMN [DepartmentSubjectDepartmentId] int NOT NULL;

GO

ALTER TABLE [Tests] ADD CONSTRAINT [PK_Tests] PRIMARY KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjecttId], [StudentId], [TermId]);

GO

ALTER TABLE [Tests] ADD CONSTRAINT [FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId] FOREIGN KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjecttId]) REFERENCES [DepartmentSubject] ([DepartmentId], [SubjectId]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191118190915_TestClassRepaired', N'2.2.3-servicing-35854');

GO

ALTER TABLE [AcademicSections] DROP CONSTRAINT [FK_AcademicSections_Term_Term1Id];

GO

ALTER TABLE [AcademicSections] DROP CONSTRAINT [FK_AcademicSections_Term_Term2Id];

GO

ALTER TABLE [AcademicSections] DROP CONSTRAINT [FK_AcademicSections_Term_Term3Id];

GO

ALTER TABLE [Exams] DROP CONSTRAINT [FK_Exams_Term_TermId];

GO

ALTER TABLE [Tests] DROP CONSTRAINT [FK_Tests_Term_TermId];

GO

ALTER TABLE [Term] DROP CONSTRAINT [PK_Term];

GO

EXEC sp_rename N'[Term]', N'Terms';

GO

EXEC sp_rename N'[AcademicSections].[Term3Id]', N'ThirdTermId', N'COLUMN';

GO

EXEC sp_rename N'[AcademicSections].[Term2Id]', N'SecondTermId', N'COLUMN';

GO

EXEC sp_rename N'[AcademicSections].[Term1Id]', N'FirstTermId', N'COLUMN';

GO

EXEC sp_rename N'[AcademicSections].[IX_AcademicSections_Term3Id]', N'IX_AcademicSections_ThirdTermId', N'INDEX';

GO

EXEC sp_rename N'[AcademicSections].[IX_AcademicSections_Term2Id]', N'IX_AcademicSections_SecondTermId', N'INDEX';

GO

EXEC sp_rename N'[AcademicSections].[IX_AcademicSections_Term1Id]', N'IX_AcademicSections_FirstTermId', N'INDEX';

GO

ALTER TABLE [Terms] ADD CONSTRAINT [PK_Terms] PRIMARY KEY ([Id]);

GO

ALTER TABLE [AcademicSections] ADD CONSTRAINT [FK_AcademicSections_Terms_FirstTermId] FOREIGN KEY ([FirstTermId]) REFERENCES [Terms] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [AcademicSections] ADD CONSTRAINT [FK_AcademicSections_Terms_SecondTermId] FOREIGN KEY ([SecondTermId]) REFERENCES [Terms] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [AcademicSections] ADD CONSTRAINT [FK_AcademicSections_Terms_ThirdTermId] FOREIGN KEY ([ThirdTermId]) REFERENCES [Terms] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [Exams] ADD CONSTRAINT [FK_Exams_Terms_TermId] FOREIGN KEY ([TermId]) REFERENCES [Terms] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [Tests] ADD CONSTRAINT [FK_Tests_Terms_TermId] FOREIGN KEY ([TermId]) REFERENCES [Terms] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191118203645_AcademicSectionPropertiesRenamed', N'2.2.3-servicing-35854');

GO

ALTER TABLE [DepartmentSubject] DROP CONSTRAINT [FK_DepartmentSubject_Departments_DepartmentId];

GO

ALTER TABLE [DepartmentSubject] DROP CONSTRAINT [FK_DepartmentSubject_Subjects_SubjectId];

GO

ALTER TABLE [Exams] DROP CONSTRAINT [FK_Exams_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId];

GO

ALTER TABLE [Tests] DROP CONSTRAINT [FK_Tests_DepartmentSubject_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId];

GO

ALTER TABLE [DepartmentSubject] DROP CONSTRAINT [PK_DepartmentSubject];

GO

EXEC sp_rename N'[DepartmentSubject]', N'departmentSubjects';

GO

EXEC sp_rename N'[departmentSubjects].[IX_DepartmentSubject_SubjectId]', N'IX_departmentSubjects_SubjectId', N'INDEX';

GO

ALTER TABLE [departmentSubjects] ADD CONSTRAINT [PK_departmentSubjects] PRIMARY KEY ([DepartmentId], [SubjectId]);

GO

ALTER TABLE [departmentSubjects] ADD CONSTRAINT [FK_departmentSubjects_Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [departmentSubjects] ADD CONSTRAINT [FK_departmentSubjects_Subjects_SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [Subjects] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [Exams] ADD CONSTRAINT [FK_Exams_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId] FOREIGN KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjecttId]) REFERENCES [departmentSubjects] ([DepartmentId], [SubjectId]) ON DELETE CASCADE;

GO

ALTER TABLE [Tests] ADD CONSTRAINT [FK_Tests_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId] FOREIGN KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjecttId]) REFERENCES [departmentSubjects] ([DepartmentId], [SubjectId]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191122081020_Add-DepartmentSubject-To-DbContext', N'2.2.3-servicing-35854');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191122092730_Add-ForeingKey-DepartmentSubject-SubjectId-and-DepartmentId', N'2.2.3-servicing-35854');

GO

ALTER TABLE [Tests] DROP CONSTRAINT [FK_Tests_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjecttId];

GO

ALTER TABLE [Tests] DROP CONSTRAINT [PK_Tests];

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tests]') AND [c].[name] = N'DepartmentSubjectSubjecttId');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Tests] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Tests] DROP COLUMN [DepartmentSubjectSubjecttId];

GO

ALTER TABLE [Tests] ADD CONSTRAINT [PK_Tests] PRIMARY KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjectId], [StudentId], [TermId]);

GO

ALTER TABLE [Tests] ADD CONSTRAINT [FK_Tests_departmentSubjects_DepartmentSubjectDepartmentId_DepartmentSubjectSubjectId] FOREIGN KEY ([DepartmentSubjectDepartmentId], [DepartmentSubjectSubjectId]) REFERENCES [departmentSubjects] ([DepartmentId], [SubjectId]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191128214409_fix-spelling-errorr', N'2.2.3-servicing-35854');

GO

CREATE TABLE [Messages] (
    [Id] int NOT NULL IDENTITY,
    [SenderId] uniqueidentifier NOT NULL,
    [RecieverId] uniqueidentifier NOT NULL,
    [Content] nvarchar(max) NULL,
    [Received] bit NOT NULL,
    CONSTRAINT [PK_Messages] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191205193053_Add-Message-to-model', N'2.2.3-servicing-35854');

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'ProfileImage');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [AspNetUsers] DROP COLUMN [ProfileImage];

GO

ALTER TABLE [AspNetUsers] ADD [ProfilePhotoExtension] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191211193915_change-ApplicationUser-profileImage-to-ImageExtension', N'2.2.3-servicing-35854');

GO

