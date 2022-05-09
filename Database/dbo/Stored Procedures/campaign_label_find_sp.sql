CREATE   procedure [dbo].[campaign_label_find_sp]
(
    @LabelIds       IntListType readonly,
    @CampaignID     int,
    @CampaignIDSort int,
    @CategoryID     int,
    @Name           nvarchar(75)
)
as

SELECT 
		[RowNumber] = rank() over (order by LabelID)
		, LabelID
		, CategoryID
		, [Name]
		, [CategoryName] = 'CategoryName'
	FROM [dbo].[campaign_label]
	ORDER BY [RowNumber]