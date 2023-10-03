use [Electronic_Store];
/*
Creating the category table
*/
CREATE TABLE [dbo].[Category] (
    [CateId]   INT         IDENTITY (1, 1) NOT NULL,
    [Category] NCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([CateId] ASC)
);


/*
Creating the brand table
*/
CREATE TABLE [dbo].[Brand] (
    [BrandId]   INT        IDENTITY (1, 1) NOT NULL,
    [BrandName] NCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([BrandId] ASC)
);


/*
Creating the product table
*/
CREATE TABLE [dbo].[Item] (
    [ModelNo]   NVARCHAR (20) NULL,
    [CateId]    INT            NULL,
    [BrandName] NVARCHAR (50) NULL,
    [ItemType]  NVARCHAR (70) NULL,
    [Quantity]  INT            NULL,
    [Price]     INT            NULL,
    [Date]      DATE           NULL
);



/*
Creating the sold table.
*/
	CREATE TABLE [dbo].[Sold] (
    [SId]       INT            IDENTITY (1, 1) NOT NULL,
    [ModelNo]   NVARCHAR (20) NULL,
    [Category]  NVARCHAR (30)  NULL,
    [ItemType]  NVARCHAR (70)  NULL,
    [BrandName] NVARCHAR (50)  NULL,
    [Quantity]  INT            NULL,
    [Price]     INT            NULL,
    [Date]      DATE           NULL,
    PRIMARY KEY CLUSTERED ([SId] ASC)
);


/*
Creating the model table.
*/
CREATE TABLE [dbo].[Model] (
    [Id]       INT        IDENTITY (1, 1) NOT NULL,
    [Model_no] NCHAR (30) NULL,
    [CateId]   INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


/*
Creating the register table.
*/
CREATE TABLE [dbo].[Register] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [email]    VARCHAR (50) NULL,
    [username] VARCHAR (50) NULL,
    [password] VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


