CREATE TABLE [dbo].[Address] (
    [ID]             BIGINT        IDENTITY (1, 1) NOT NULL,
    [VendorID]       BIGINT        NOT NULL,
    [StreetAddress]  VARCHAR (100) NULL,
    [StreetAddress2] VARCHAR (100) NULL,
    [City]           VARCHAR (50)  NULL,
    [State]          VARCHAR (50)  NULL,
    [Country]        VARCHAR (50)  NULL,
    [Zipcode]        NVARCHAR (10) NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Address_Vendor] FOREIGN KEY ([VendorID]) REFERENCES [dbo].[Vendor] ([ID])
);

