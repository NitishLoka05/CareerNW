CREATE TABLE [dbo].[EMail] (
    [ID]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [VendorID] BIGINT       NOT NULL,
    [Address]  VARCHAR (50) NULL,
    CONSTRAINT [PK_EMail] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_EMail_Vendor] FOREIGN KEY ([VendorID]) REFERENCES [dbo].[Vendor] ([ID])
);

