CREATE TABLE [dbo].[PhoneType] (
    [ID]      INT          IDENTITY (1, 1) NOT NULL,
    [PhoneID] BIGINT       NOT NULL,
    [Type]    VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_PhoneType] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_PhoneType_Phone] FOREIGN KEY ([PhoneID]) REFERENCES [dbo].[Phone] ([ID])
);

