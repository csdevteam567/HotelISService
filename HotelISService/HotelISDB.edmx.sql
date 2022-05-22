
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/01/2019 16:19:25
-- Generated from EDMX file: D:\Projects\BaseCourse\HotelISService\HotelISService\HotelISDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HotelISDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RestaurantMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_RestaurantMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_MenuOrderedDishes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderedDishes] DROP CONSTRAINT [FK_MenuOrderedDishes];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderOrderedDish]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderedDishes] DROP CONSTRAINT [FK_OrderOrderedDish];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderOrderedApartment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderedApartments] DROP CONSTRAINT [FK_OrderOrderedApartment];
GO
IF OBJECT_ID(N'[dbo].[FK_FloorApartment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Apartments] DROP CONSTRAINT [FK_FloorApartment];
GO
IF OBJECT_ID(N'[dbo].[FK_UserOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_UserOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_ApartmentOrderedApartment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderedApartments] DROP CONSTRAINT [FK_ApartmentOrderedApartment];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryCity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cities] DROP CONSTRAINT [FK_CountryCity];
GO
IF OBJECT_ID(N'[dbo].[FK_HotelRestaurant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Restaurants] DROP CONSTRAINT [FK_HotelRestaurant];
GO
IF OBJECT_ID(N'[dbo].[FK_HotelFloor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Floors] DROP CONSTRAINT [FK_HotelFloor];
GO
IF OBJECT_ID(N'[dbo].[FK_CityHotel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Hotels] DROP CONSTRAINT [FK_CityHotel];
GO
IF OBJECT_ID(N'[dbo].[FK_GuestOrderedApartment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderedApartments] DROP CONSTRAINT [FK_GuestOrderedApartment];
GO
IF OBJECT_ID(N'[dbo].[FK_HotelOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_HotelOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_GuestOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_GuestOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_GuestChildParentParent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChildParents] DROP CONSTRAINT [FK_GuestChildParentParent];
GO
IF OBJECT_ID(N'[dbo].[FK_GuestChildParentChild]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChildParents] DROP CONSTRAINT [FK_GuestChildParentChild];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Apartments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Apartments];
GO
IF OBJECT_ID(N'[dbo].[Guests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Guests];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[Restaurants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurants];
GO
IF OBJECT_ID(N'[dbo].[Menus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menus];
GO
IF OBJECT_ID(N'[dbo].[OrderedDishes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderedDishes];
GO
IF OBJECT_ID(N'[dbo].[Floors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Floors];
GO
IF OBJECT_ID(N'[dbo].[OrderedApartments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderedApartments];
GO
IF OBJECT_ID(N'[dbo].[Countries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Countries];
GO
IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[Hotels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hotels];
GO
IF OBJECT_ID(N'[dbo].[ChildParents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChildParents];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Role] int  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Apartments'
CREATE TABLE [dbo].[Apartments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Number] int  NOT NULL,
    [TypeVip] bit  NOT NULL,
    [MaxCapacity] int  NOT NULL,
    [RoomsNumber] int  NOT NULL,
    [Price] float  NOT NULL,
    [FloorId] int  NOT NULL
);
GO

-- Creating table 'Guests'
CREATE TABLE [dbo].[Guests] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PassportNumber] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [MiddleName] nvarchar(max)  NULL,
    [DateOfBirth] datetime  NOT NULL,
    [Sex] nvarchar(max)  NOT NULL,
    [StatusVip] bit  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Discount] float  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OrderDate] datetime  NOT NULL,
    [TotalPrice] float  NOT NULL,
    [UserId] int  NOT NULL,
    [HotelId] int  NOT NULL,
    [GuestId] int  NOT NULL
);
GO

-- Creating table 'Restaurants'
CREATE TABLE [dbo].[Restaurants] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [HotelId] int  NOT NULL
);
GO

-- Creating table 'Menus'
CREATE TABLE [dbo].[Menus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DishName] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [RestaurantId] int  NOT NULL
);
GO

-- Creating table 'OrderedDishes'
CREATE TABLE [dbo].[OrderedDishes] (
    [MenuId] int  NOT NULL,
    [OrderId] int  NOT NULL
);
GO

-- Creating table 'Floors'
CREATE TABLE [dbo].[Floors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MaxApartments] int  NOT NULL,
    [FloorNum] int  NOT NULL,
    [HotelId] int  NOT NULL
);
GO

-- Creating table 'OrderedApartments'
CREATE TABLE [dbo].[OrderedApartments] (
    [OrderId] int  NOT NULL,
    [ApartmentId] int  NOT NULL,
    [GuestId] int  NOT NULL,
    [ActualDepartureDate] datetime  NOT NULL
);
GO

-- Creating table 'Countries'
CREATE TABLE [dbo].[Countries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CountryId] int  NOT NULL
);
GO

-- Creating table 'Hotels'
CREATE TABLE [dbo].[Hotels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Rating] int  NOT NULL,
    [HasRestaurant] bit  NOT NULL,
    [MaxFloorsCount] int  NOT NULL,
    [CityId] int  NOT NULL
);
GO

-- Creating table 'ChildParents'
CREATE TABLE [dbo].[ChildParents] (
    [ParentId] int  NOT NULL,
    [ChildId] int  NOT NULL
);
GO

-- Creating table 'FamilyRelations'
CREATE TABLE [dbo].[FamilyRelations] (
    [GuestId] int  NOT NULL,
    [RelativeId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Apartments'
ALTER TABLE [dbo].[Apartments]
ADD CONSTRAINT [PK_Apartments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Guests'
ALTER TABLE [dbo].[Guests]
ADD CONSTRAINT [PK_Guests]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Restaurants'
ALTER TABLE [dbo].[Restaurants]
ADD CONSTRAINT [PK_Restaurants]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [PK_Menus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [OrderId], [MenuId] in table 'OrderedDishes'
ALTER TABLE [dbo].[OrderedDishes]
ADD CONSTRAINT [PK_OrderedDishes]
    PRIMARY KEY NONCLUSTERED ([OrderId], [MenuId] ASC);
GO

-- Creating primary key on [Id] in table 'Floors'
ALTER TABLE [dbo].[Floors]
ADD CONSTRAINT [PK_Floors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [OrderId], [ApartmentId], [GuestId] in table 'OrderedApartments'
ALTER TABLE [dbo].[OrderedApartments]
ADD CONSTRAINT [PK_OrderedApartments]
    PRIMARY KEY CLUSTERED ([OrderId], [ApartmentId], [GuestId] ASC);
GO

-- Creating primary key on [Id] in table 'Countries'
ALTER TABLE [dbo].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Hotels'
ALTER TABLE [dbo].[Hotels]
ADD CONSTRAINT [PK_Hotels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ChildId], [ParentId] in table 'ChildParents'
ALTER TABLE [dbo].[ChildParents]
ADD CONSTRAINT [PK_ChildParents]
    PRIMARY KEY NONCLUSTERED ([ChildId], [ParentId] ASC);
GO

-- Creating primary key on [RelativeId], [GuestId] in table 'FamilyRelations'
ALTER TABLE [dbo].[FamilyRelations]
ADD CONSTRAINT [PK_FamilyRelations]
    PRIMARY KEY NONCLUSTERED ([RelativeId], [GuestId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RestaurantId] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [FK_RestaurantMenu]
    FOREIGN KEY ([RestaurantId])
    REFERENCES [dbo].[Restaurants]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantMenu'
CREATE INDEX [IX_FK_RestaurantMenu]
ON [dbo].[Menus]
    ([RestaurantId]);
GO

-- Creating foreign key on [MenuId] in table 'OrderedDishes'
ALTER TABLE [dbo].[OrderedDishes]
ADD CONSTRAINT [FK_MenuOrderedDishes]
    FOREIGN KEY ([MenuId])
    REFERENCES [dbo].[Menus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MenuOrderedDishes'
CREATE INDEX [IX_FK_MenuOrderedDishes]
ON [dbo].[OrderedDishes]
    ([MenuId]);
GO

-- Creating foreign key on [OrderId] in table 'OrderedDishes'
ALTER TABLE [dbo].[OrderedDishes]
ADD CONSTRAINT [FK_OrderOrderedDish]
    FOREIGN KEY ([OrderId])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OrderId] in table 'OrderedApartments'
ALTER TABLE [dbo].[OrderedApartments]
ADD CONSTRAINT [FK_OrderOrderedApartment]
    FOREIGN KEY ([OrderId])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FloorId] in table 'Apartments'
ALTER TABLE [dbo].[Apartments]
ADD CONSTRAINT [FK_FloorApartment]
    FOREIGN KEY ([FloorId])
    REFERENCES [dbo].[Floors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FloorApartment'
CREATE INDEX [IX_FK_FloorApartment]
ON [dbo].[Apartments]
    ([FloorId]);
GO

-- Creating foreign key on [UserId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_UserOrder]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserOrder'
CREATE INDEX [IX_FK_UserOrder]
ON [dbo].[Orders]
    ([UserId]);
GO

-- Creating foreign key on [ApartmentId] in table 'OrderedApartments'
ALTER TABLE [dbo].[OrderedApartments]
ADD CONSTRAINT [FK_ApartmentOrderedApartment]
    FOREIGN KEY ([ApartmentId])
    REFERENCES [dbo].[Apartments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ApartmentOrderedApartment'
CREATE INDEX [IX_FK_ApartmentOrderedApartment]
ON [dbo].[OrderedApartments]
    ([ApartmentId]);
GO

-- Creating foreign key on [CountryId] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [FK_CountryCity]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryCity'
CREATE INDEX [IX_FK_CountryCity]
ON [dbo].[Cities]
    ([CountryId]);
GO

-- Creating foreign key on [HotelId] in table 'Restaurants'
ALTER TABLE [dbo].[Restaurants]
ADD CONSTRAINT [FK_HotelRestaurant]
    FOREIGN KEY ([HotelId])
    REFERENCES [dbo].[Hotels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HotelRestaurant'
CREATE INDEX [IX_FK_HotelRestaurant]
ON [dbo].[Restaurants]
    ([HotelId]);
GO

-- Creating foreign key on [HotelId] in table 'Floors'
ALTER TABLE [dbo].[Floors]
ADD CONSTRAINT [FK_HotelFloor]
    FOREIGN KEY ([HotelId])
    REFERENCES [dbo].[Hotels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HotelFloor'
CREATE INDEX [IX_FK_HotelFloor]
ON [dbo].[Floors]
    ([HotelId]);
GO

-- Creating foreign key on [CityId] in table 'Hotels'
ALTER TABLE [dbo].[Hotels]
ADD CONSTRAINT [FK_CityHotel]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CityHotel'
CREATE INDEX [IX_FK_CityHotel]
ON [dbo].[Hotels]
    ([CityId]);
GO

-- Creating foreign key on [GuestId] in table 'OrderedApartments'
ALTER TABLE [dbo].[OrderedApartments]
ADD CONSTRAINT [FK_GuestOrderedApartment]
    FOREIGN KEY ([GuestId])
    REFERENCES [dbo].[Guests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GuestOrderedApartment'
CREATE INDEX [IX_FK_GuestOrderedApartment]
ON [dbo].[OrderedApartments]
    ([GuestId]);
GO

-- Creating foreign key on [HotelId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_HotelOrder]
    FOREIGN KEY ([HotelId])
    REFERENCES [dbo].[Hotels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HotelOrder'
CREATE INDEX [IX_FK_HotelOrder]
ON [dbo].[Orders]
    ([HotelId]);
GO

-- Creating foreign key on [GuestId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_GuestOrder]
    FOREIGN KEY ([GuestId])
    REFERENCES [dbo].[Guests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GuestOrder'
CREATE INDEX [IX_FK_GuestOrder]
ON [dbo].[Orders]
    ([GuestId]);
GO

-- Creating foreign key on [ParentId] in table 'ChildParents'
ALTER TABLE [dbo].[ChildParents]
ADD CONSTRAINT [FK_GuestChildParentParent]
    FOREIGN KEY ([ParentId])
    REFERENCES [dbo].[Guests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GuestChildParentParent'
CREATE INDEX [IX_FK_GuestChildParentParent]
ON [dbo].[ChildParents]
    ([ParentId]);
GO

-- Creating foreign key on [ChildId] in table 'ChildParents'
ALTER TABLE [dbo].[ChildParents]
ADD CONSTRAINT [FK_GuestChildParentChild]
    FOREIGN KEY ([ChildId])
    REFERENCES [dbo].[Guests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [GuestId] in table 'FamilyRelations'
ALTER TABLE [dbo].[FamilyRelations]
ADD CONSTRAINT [FK_GuestFamilyRelation]
    FOREIGN KEY ([GuestId])
    REFERENCES [dbo].[Guests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GuestFamilyRelation'
CREATE INDEX [IX_FK_GuestFamilyRelation]
ON [dbo].[FamilyRelations]
    ([GuestId]);
GO

-- Creating foreign key on [RelativeId] in table 'FamilyRelations'
ALTER TABLE [dbo].[FamilyRelations]
ADD CONSTRAINT [FK_GuestFamilyRelation1]
    FOREIGN KEY ([RelativeId])
    REFERENCES [dbo].[Guests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------