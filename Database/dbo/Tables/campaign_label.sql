CREATE TABLE [dbo].[campaign_label] (
    [LabelID]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (75) NOT NULL,
    [CategoryID] INT           NOT NULL,
    CONSTRAINT [PK_CAMPAIGN_LABEL] PRIMARY KEY CLUSTERED ([LabelID] ASC),
    CONSTRAINT [AK_CAMPAIGN_LABEL_NAME_CATEGORY] UNIQUE NONCLUSTERED ([Name] ASC, [CategoryID] ASC)
);

