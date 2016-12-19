CREATE TABLE [dbo].[Vendor] (
    [ID]             BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (50) NOT NULL,
    [IsPrime]        BIT          NULL,
    [LastUpdateDate] DATETIME     NULL,
    [CreateDate]     DATETIME     CONSTRAINT [DF_Vendor_CreateDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED ([ID] ASC)
);

