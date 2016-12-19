CREATE TABLE [dbo].[Phone] (
    [ID]          BIGINT       IDENTITY (1, 1) NOT NULL,
    [VendorID]    BIGINT       NOT NULL,
    [CountryCode] VARCHAR (5)  NULL,
    [Number]      VARCHAR (10) NULL,
    [Extension]   VARCHAR (5)  NULL,
    CONSTRAINT [PK_Phone] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Phone_Vendor] FOREIGN KEY ([VendorID]) REFERENCES [dbo].[Vendor] ([ID])
);

