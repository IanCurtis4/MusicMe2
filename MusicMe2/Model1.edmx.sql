
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/23/2019 14:13:57
-- Generated from EDMX file: F:\Faculdade\MusicMe2\MusicMe2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [F:\FACULDADE\MUSICME2\MUSICME2\APP_DATA\ASPNET-MUSICME2-20190914113515.MDF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_CommentLike]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LikeSet] DROP CONSTRAINT [FK_CommentLike];
GO
IF OBJECT_ID(N'[dbo].[FK_PostComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommentSet] DROP CONSTRAINT [FK_PostComment];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfileComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommentSet] DROP CONSTRAINT [FK_ProfileComment];
GO
IF OBJECT_ID(N'[dbo].[FK_MusicLike]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LikeSet] DROP CONSTRAINT [FK_MusicLike];
GO
IF OBJECT_ID(N'[dbo].[FK_PlaylistLike]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LikeSet] DROP CONSTRAINT [FK_PlaylistLike];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfileLike]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LikeSet] DROP CONSTRAINT [FK_ProfileLike];
GO
IF OBJECT_ID(N'[dbo].[FK_MusicShare]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ShareSet] DROP CONSTRAINT [FK_MusicShare];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfileMusic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MusicSet] DROP CONSTRAINT [FK_ProfileMusic];
GO
IF OBJECT_ID(N'[dbo].[FK_PlaylistShare]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ShareSet] DROP CONSTRAINT [FK_PlaylistShare];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfilePlaylist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlaylistSet] DROP CONSTRAINT [FK_ProfilePlaylist];
GO
IF OBJECT_ID(N'[dbo].[FK_PostShare]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ShareSet] DROP CONSTRAINT [FK_PostShare];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfilePost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PostSet] DROP CONSTRAINT [FK_ProfilePost];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfileShare]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ShareSet] DROP CONSTRAINT [FK_ProfileShare];
GO
IF OBJECT_ID(N'[dbo].[FK_AspNetUserRoles_AspNetRoles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[FK_AspNetUserRoles_AspNetUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_PlaylistMusic_MusicSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlaylistMusic] DROP CONSTRAINT [FK_PlaylistMusic_MusicSet];
GO
IF OBJECT_ID(N'[dbo].[FK_PlaylistMusic_PlaylistSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlaylistMusic] DROP CONSTRAINT [FK_PlaylistMusic_PlaylistSet];
GO
IF OBJECT_ID(N'[dbo].[FK_FriendSet_ToProfileDestiny]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FriendSet] DROP CONSTRAINT [FK_FriendSet_ToProfileDestiny];
GO
IF OBJECT_ID(N'[dbo].[FK_FriendSet_ToProfileOrigin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FriendSet] DROP CONSTRAINT [FK_FriendSet_ToProfileOrigin];
GO
IF OBJECT_ID(N'[dbo].[FK_PostLike]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LikeSet] DROP CONSTRAINT [FK_PostLike];
GO
IF OBJECT_ID(N'[dbo].[FK_PostMusic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MusicSet] DROP CONSTRAINT [FK_PostMusic];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AspNetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserClaims];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserLogins];
GO
IF OBJECT_ID(N'[dbo].[AspNetUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[C__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[C__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[CommentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommentSet];
GO
IF OBJECT_ID(N'[dbo].[FriendSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FriendSet];
GO
IF OBJECT_ID(N'[dbo].[LikeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LikeSet];
GO
IF OBJECT_ID(N'[dbo].[MusicSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MusicSet];
GO
IF OBJECT_ID(N'[dbo].[PlaylistSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlaylistSet];
GO
IF OBJECT_ID(N'[dbo].[PostSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PostSet];
GO
IF OBJECT_ID(N'[dbo].[ProfileSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfileSet];
GO
IF OBJECT_ID(N'[dbo].[ShareSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ShareSet];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserRoles];
GO
IF OBJECT_ID(N'[dbo].[PlaylistMusic]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlaylistMusic];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AspNetRoles'
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'AspNetUserClaims'
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetUserLogins'
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUsers'
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] nvarchar(128)  NOT NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'CommentSet'
CREATE TABLE [dbo].[CommentSet] (
    [CommentId] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Midia] nvarchar(max)  NULL,
    [ProfileProfileId] int  NOT NULL,
    [PostPostId] int  NULL
);
GO

-- Creating table 'FriendSet'
CREATE TABLE [dbo].[FriendSet] (
    [FriendId] int IDENTITY(1,1) NOT NULL,
    [Friended] bit  NOT NULL,
    [ProfileOriginId] int  NOT NULL,
    [ProfileDestinyId] int  NOT NULL
);
GO

-- Creating table 'LikeSet'
CREATE TABLE [dbo].[LikeSet] (
    [LikeId] int IDENTITY(1,1) NOT NULL,
    [Liked] nvarchar(max)  NOT NULL,
    [ProfileProfileId] int  NOT NULL,
    [MusicMusicId] int  NULL,
    [PlaylistPlaylistId] int  NULL,
    [CommentCommentId] int  NULL,
    [PostPostId] int  NULL
);
GO

-- Creating table 'MusicSet'
CREATE TABLE [dbo].[MusicSet] (
    [MusicId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Band] nvarchar(max)  NOT NULL,
    [Album] nvarchar(max)  NOT NULL,
    [Midia] nvarchar(max)  NOT NULL,
    [ProfileProfileId] int  NOT NULL,
    [Post_PostId] int  NULL
);
GO

-- Creating table 'PlaylistSet'
CREATE TABLE [dbo].[PlaylistSet] (
    [PlaylistId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ProfileProfileId] int  NOT NULL
);
GO

-- Creating table 'PostSet'
CREATE TABLE [dbo].[PostSet] (
    [PostId] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Midia] nvarchar(max)  NULL,
    [ProfileProfileId] int  NULL
);
GO

-- Creating table 'ProfileSet'
CREATE TABLE [dbo].[ProfileSet] (
    [ProfileId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [ProfilePicture] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [Email] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'ShareSet'
CREATE TABLE [dbo].[ShareSet] (
    [ShareId] int IDENTITY(1,1) NOT NULL,
    [ProfileProfileId] int  NOT NULL,
    [MusicMusicId] int  NULL,
    [PlaylistPlaylistId] int  NULL,
    [PostPostId] int  NULL
);
GO

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [AspNetRoles_Id] nvarchar(128)  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'PlaylistMusic'
CREATE TABLE [dbo].[PlaylistMusic] (
    [MusicSet_MusicId] int  NOT NULL,
    [PlaylistSet_PlaylistId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AspNetRoles'
ALTER TABLE [dbo].[AspNetRoles]
ADD CONSTRAINT [PK_AspNetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [PK_AspNetUserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [PK_AspNetUserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [CommentId] in table 'CommentSet'
ALTER TABLE [dbo].[CommentSet]
ADD CONSTRAINT [PK_CommentSet]
    PRIMARY KEY CLUSTERED ([CommentId] ASC);
GO

-- Creating primary key on [FriendId] in table 'FriendSet'
ALTER TABLE [dbo].[FriendSet]
ADD CONSTRAINT [PK_FriendSet]
    PRIMARY KEY CLUSTERED ([FriendId] ASC);
GO

-- Creating primary key on [LikeId] in table 'LikeSet'
ALTER TABLE [dbo].[LikeSet]
ADD CONSTRAINT [PK_LikeSet]
    PRIMARY KEY CLUSTERED ([LikeId] ASC);
GO

-- Creating primary key on [MusicId] in table 'MusicSet'
ALTER TABLE [dbo].[MusicSet]
ADD CONSTRAINT [PK_MusicSet]
    PRIMARY KEY CLUSTERED ([MusicId] ASC);
GO

-- Creating primary key on [PlaylistId] in table 'PlaylistSet'
ALTER TABLE [dbo].[PlaylistSet]
ADD CONSTRAINT [PK_PlaylistSet]
    PRIMARY KEY CLUSTERED ([PlaylistId] ASC);
GO

-- Creating primary key on [PostId] in table 'PostSet'
ALTER TABLE [dbo].[PostSet]
ADD CONSTRAINT [PK_PostSet]
    PRIMARY KEY CLUSTERED ([PostId] ASC);
GO

-- Creating primary key on [ProfileId] in table 'ProfileSet'
ALTER TABLE [dbo].[ProfileSet]
ADD CONSTRAINT [PK_ProfileSet]
    PRIMARY KEY CLUSTERED ([ProfileId] ASC);
GO

-- Creating primary key on [ShareId] in table 'ShareSet'
ALTER TABLE [dbo].[ShareSet]
ADD CONSTRAINT [PK_ShareSet]
    PRIMARY KEY CLUSTERED ([ShareId] ASC);
GO

-- Creating primary key on [AspNetRoles_Id], [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([AspNetRoles_Id], [AspNetUsers_Id] ASC);
GO

-- Creating primary key on [MusicSet_MusicId], [PlaylistSet_PlaylistId] in table 'PlaylistMusic'
ALTER TABLE [dbo].[PlaylistMusic]
ADD CONSTRAINT [PK_PlaylistMusic]
    PRIMARY KEY CLUSTERED ([MusicSet_MusicId], [PlaylistSet_PlaylistId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserLogins]
    ([UserId]);
GO

-- Creating foreign key on [CommentCommentId] in table 'LikeSet'
ALTER TABLE [dbo].[LikeSet]
ADD CONSTRAINT [FK_CommentLike]
    FOREIGN KEY ([CommentCommentId])
    REFERENCES [dbo].[CommentSet]
        ([CommentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentLike'
CREATE INDEX [IX_FK_CommentLike]
ON [dbo].[LikeSet]
    ([CommentCommentId]);
GO

-- Creating foreign key on [PostPostId] in table 'CommentSet'
ALTER TABLE [dbo].[CommentSet]
ADD CONSTRAINT [FK_PostComment]
    FOREIGN KEY ([PostPostId])
    REFERENCES [dbo].[PostSet]
        ([PostId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PostComment'
CREATE INDEX [IX_FK_PostComment]
ON [dbo].[CommentSet]
    ([PostPostId]);
GO

-- Creating foreign key on [ProfileProfileId] in table 'CommentSet'
ALTER TABLE [dbo].[CommentSet]
ADD CONSTRAINT [FK_ProfileComment]
    FOREIGN KEY ([ProfileProfileId])
    REFERENCES [dbo].[ProfileSet]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfileComment'
CREATE INDEX [IX_FK_ProfileComment]
ON [dbo].[CommentSet]
    ([ProfileProfileId]);
GO

-- Creating foreign key on [MusicMusicId] in table 'LikeSet'
ALTER TABLE [dbo].[LikeSet]
ADD CONSTRAINT [FK_MusicLike]
    FOREIGN KEY ([MusicMusicId])
    REFERENCES [dbo].[MusicSet]
        ([MusicId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MusicLike'
CREATE INDEX [IX_FK_MusicLike]
ON [dbo].[LikeSet]
    ([MusicMusicId]);
GO

-- Creating foreign key on [PlaylistPlaylistId] in table 'LikeSet'
ALTER TABLE [dbo].[LikeSet]
ADD CONSTRAINT [FK_PlaylistLike]
    FOREIGN KEY ([PlaylistPlaylistId])
    REFERENCES [dbo].[PlaylistSet]
        ([PlaylistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlaylistLike'
CREATE INDEX [IX_FK_PlaylistLike]
ON [dbo].[LikeSet]
    ([PlaylistPlaylistId]);
GO

-- Creating foreign key on [ProfileProfileId] in table 'LikeSet'
ALTER TABLE [dbo].[LikeSet]
ADD CONSTRAINT [FK_ProfileLike]
    FOREIGN KEY ([ProfileProfileId])
    REFERENCES [dbo].[ProfileSet]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfileLike'
CREATE INDEX [IX_FK_ProfileLike]
ON [dbo].[LikeSet]
    ([ProfileProfileId]);
GO

-- Creating foreign key on [MusicMusicId] in table 'ShareSet'
ALTER TABLE [dbo].[ShareSet]
ADD CONSTRAINT [FK_MusicShare]
    FOREIGN KEY ([MusicMusicId])
    REFERENCES [dbo].[MusicSet]
        ([MusicId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MusicShare'
CREATE INDEX [IX_FK_MusicShare]
ON [dbo].[ShareSet]
    ([MusicMusicId]);
GO

-- Creating foreign key on [ProfileProfileId] in table 'MusicSet'
ALTER TABLE [dbo].[MusicSet]
ADD CONSTRAINT [FK_ProfileMusic]
    FOREIGN KEY ([ProfileProfileId])
    REFERENCES [dbo].[ProfileSet]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfileMusic'
CREATE INDEX [IX_FK_ProfileMusic]
ON [dbo].[MusicSet]
    ([ProfileProfileId]);
GO

-- Creating foreign key on [PlaylistPlaylistId] in table 'ShareSet'
ALTER TABLE [dbo].[ShareSet]
ADD CONSTRAINT [FK_PlaylistShare]
    FOREIGN KEY ([PlaylistPlaylistId])
    REFERENCES [dbo].[PlaylistSet]
        ([PlaylistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlaylistShare'
CREATE INDEX [IX_FK_PlaylistShare]
ON [dbo].[ShareSet]
    ([PlaylistPlaylistId]);
GO

-- Creating foreign key on [ProfileProfileId] in table 'PlaylistSet'
ALTER TABLE [dbo].[PlaylistSet]
ADD CONSTRAINT [FK_ProfilePlaylist]
    FOREIGN KEY ([ProfileProfileId])
    REFERENCES [dbo].[ProfileSet]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfilePlaylist'
CREATE INDEX [IX_FK_ProfilePlaylist]
ON [dbo].[PlaylistSet]
    ([ProfileProfileId]);
GO

-- Creating foreign key on [PostPostId] in table 'ShareSet'
ALTER TABLE [dbo].[ShareSet]
ADD CONSTRAINT [FK_PostShare]
    FOREIGN KEY ([PostPostId])
    REFERENCES [dbo].[PostSet]
        ([PostId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PostShare'
CREATE INDEX [IX_FK_PostShare]
ON [dbo].[ShareSet]
    ([PostPostId]);
GO

-- Creating foreign key on [ProfileProfileId] in table 'PostSet'
ALTER TABLE [dbo].[PostSet]
ADD CONSTRAINT [FK_ProfilePost]
    FOREIGN KEY ([ProfileProfileId])
    REFERENCES [dbo].[ProfileSet]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfilePost'
CREATE INDEX [IX_FK_ProfilePost]
ON [dbo].[PostSet]
    ([ProfileProfileId]);
GO

-- Creating foreign key on [ProfileProfileId] in table 'ShareSet'
ALTER TABLE [dbo].[ShareSet]
ADD CONSTRAINT [FK_ProfileShare]
    FOREIGN KEY ([ProfileProfileId])
    REFERENCES [dbo].[ProfileSet]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfileShare'
CREATE INDEX [IX_FK_ProfileShare]
ON [dbo].[ShareSet]
    ([ProfileProfileId]);
GO

-- Creating foreign key on [AspNetRoles_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRoles]
    FOREIGN KEY ([AspNetRoles_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUsers]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserRoles_AspNetUsers'
CREATE INDEX [IX_FK_AspNetUserRoles_AspNetUsers]
ON [dbo].[AspNetUserRoles]
    ([AspNetUsers_Id]);
GO

-- Creating foreign key on [MusicSet_MusicId] in table 'PlaylistMusic'
ALTER TABLE [dbo].[PlaylistMusic]
ADD CONSTRAINT [FK_PlaylistMusic_MusicSet]
    FOREIGN KEY ([MusicSet_MusicId])
    REFERENCES [dbo].[MusicSet]
        ([MusicId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PlaylistSet_PlaylistId] in table 'PlaylistMusic'
ALTER TABLE [dbo].[PlaylistMusic]
ADD CONSTRAINT [FK_PlaylistMusic_PlaylistSet]
    FOREIGN KEY ([PlaylistSet_PlaylistId])
    REFERENCES [dbo].[PlaylistSet]
        ([PlaylistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlaylistMusic_PlaylistSet'
CREATE INDEX [IX_FK_PlaylistMusic_PlaylistSet]
ON [dbo].[PlaylistMusic]
    ([PlaylistSet_PlaylistId]);
GO

-- Creating foreign key on [ProfileDestinyId] in table 'FriendSet'
ALTER TABLE [dbo].[FriendSet]
ADD CONSTRAINT [FK_FriendSet_ToProfileDestiny]
    FOREIGN KEY ([ProfileDestinyId])
    REFERENCES [dbo].[ProfileSet]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FriendSet_ToProfileDestiny'
CREATE INDEX [IX_FK_FriendSet_ToProfileDestiny]
ON [dbo].[FriendSet]
    ([ProfileDestinyId]);
GO

-- Creating foreign key on [ProfileOriginId] in table 'FriendSet'
ALTER TABLE [dbo].[FriendSet]
ADD CONSTRAINT [FK_FriendSet_ToProfileOrigin]
    FOREIGN KEY ([ProfileOriginId])
    REFERENCES [dbo].[ProfileSet]
        ([ProfileId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FriendSet_ToProfileOrigin'
CREATE INDEX [IX_FK_FriendSet_ToProfileOrigin]
ON [dbo].[FriendSet]
    ([ProfileOriginId]);
GO

-- Creating foreign key on [PostPostId] in table 'LikeSet'
ALTER TABLE [dbo].[LikeSet]
ADD CONSTRAINT [FK_PostLike]
    FOREIGN KEY ([PostPostId])
    REFERENCES [dbo].[PostSet]
        ([PostId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PostLike'
CREATE INDEX [IX_FK_PostLike]
ON [dbo].[LikeSet]
    ([PostPostId]);
GO

-- Creating foreign key on [Post_PostId] in table 'MusicSet'
ALTER TABLE [dbo].[MusicSet]
ADD CONSTRAINT [FK_PostMusic]
    FOREIGN KEY ([Post_PostId])
    REFERENCES [dbo].[PostSet]
        ([PostId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PostMusic'
CREATE INDEX [IX_FK_PostMusic]
ON [dbo].[MusicSet]
    ([Post_PostId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------