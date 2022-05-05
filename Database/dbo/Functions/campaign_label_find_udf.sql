

CREATE   FUNCTION [dbo].[campaign_label_find_udf] 
(
    @LabelIds IntListType readonly,
    @CampaignID int,
    @CampaignIDSort int,
    @CategoryID int,
    @Name nvarchar(75)
)
RETURNS 
@result TABLE 
(
	[RowNumber] [int] NOT NULL PRIMARY KEY
    , [LabelId] [int] NOT NULL
	, [CategoryId] [int] NOT NULL
	, [Name] nvarchar(128) NOT NULL
	, [CategoryName] nvarchar(128) 
)
AS
BEGIN


	INSERT @result
	SELECT 
		[RowNumber] = rank() over (order by LabelID)
		, LabelID
		, CategoryID
		, [Name]
		, 'CategoryName'
	FROM [dbo].[campaign_label]
	ORDER BY [RowNumber]

	RETURN 
END