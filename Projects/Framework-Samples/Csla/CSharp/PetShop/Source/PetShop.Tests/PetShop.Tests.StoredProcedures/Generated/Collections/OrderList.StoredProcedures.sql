--region Drop Existing Procedures

IF OBJECT_ID(N'[dbo].[CSLA_Order_Insert]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Order_Insert]

IF OBJECT_ID(N'[dbo].[CSLA_Order_Update]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Order_Update]

IF OBJECT_ID(N'[dbo].[CSLA_Order_Delete]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Order_Delete]

IF OBJECT_ID(N'[dbo].[CSLA_Order_Select]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Order_Select]

--endregion

GO

--region [dbo].[CSLA_Order_Insert]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith 5.0.0.0
-- Procedure Name: [dbo].[CSLA_Order_Insert]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Order_Insert]
	@p_UserId varchar(20),
	@p_OrderDate datetime,
	@p_ShipAddr1 varchar(80),
	@p_ShipAddr2 varchar(80),
	@p_ShipCity varchar(80),
	@p_ShipState varchar(80),
	@p_ShipZip varchar(20),
	@p_ShipCountry varchar(20),
	@p_BillAddr1 varchar(80),
	@p_BillAddr2 varchar(80),
	@p_BillCity varchar(80),
	@p_BillState varchar(80),
	@p_BillZip varchar(20),
	@p_BillCountry varchar(20),
	@p_Courier varchar(80),
	@p_TotalPrice decimal(10, 2),
	@p_BillToFirstName varchar(80),
	@p_BillToLastName varchar(80),
	@p_ShipToFirstName varchar(80),
	@p_ShipToLastName varchar(80),
	@p_AuthorizationNumber int,
	@p_Locale varchar(20),
	@p_OrderId int OUTPUT
AS

SET NOCOUNT ON

INSERT INTO [dbo].[Orders] (
	[UserId],
	[OrderDate],
	[ShipAddr1],
	[ShipAddr2],
	[ShipCity],
	[ShipState],
	[ShipZip],
	[ShipCountry],
	[BillAddr1],
	[BillAddr2],
	[BillCity],
	[BillState],
	[BillZip],
	[BillCountry],
	[Courier],
	[TotalPrice],
	[BillToFirstName],
	[BillToLastName],
	[ShipToFirstName],
	[ShipToLastName],
	[AuthorizationNumber],
	[Locale]
) VALUES (
	@p_UserId,
	@p_OrderDate,
	@p_ShipAddr1,
	@p_ShipAddr2,
	@p_ShipCity,
	@p_ShipState,
	@p_ShipZip,
	@p_ShipCountry,
	@p_BillAddr1,
	@p_BillAddr2,
	@p_BillCity,
	@p_BillState,
	@p_BillZip,
	@p_BillCountry,
	@p_Courier,
	@p_TotalPrice,
	@p_BillToFirstName,
	@p_BillToLastName,
	@p_ShipToFirstName,
	@p_ShipToLastName,
	@p_AuthorizationNumber,
	@p_Locale
)

SET @OrderId = SCOPE_IDENTITY()

--endregion

GO

--region [dbo].[CSLA_Order_Update]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith 5.0.0.0
-- Procedure Name: [dbo].[CSLA_Order_Update]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Order_Update]
	@p_OrderId int,
	@p_UserId varchar(20),
	@p_OrderDate datetime,
	@p_ShipAddr1 varchar(80),
	@p_ShipAddr2 varchar(80),
	@p_ShipCity varchar(80),
	@p_ShipState varchar(80),
	@p_ShipZip varchar(20),
	@p_ShipCountry varchar(20),
	@p_BillAddr1 varchar(80),
	@p_BillAddr2 varchar(80),
	@p_BillCity varchar(80),
	@p_BillState varchar(80),
	@p_BillZip varchar(20),
	@p_BillCountry varchar(20),
	@p_Courier varchar(80),
	@p_TotalPrice decimal(10, 2),
	@p_BillToFirstName varchar(80),
	@p_BillToLastName varchar(80),
	@p_ShipToFirstName varchar(80),
	@p_ShipToLastName varchar(80),
	@p_AuthorizationNumber int,
	@p_Locale varchar(20)
AS

SET NOCOUNT ON

UPDATE [dbo].[Orders] SET
	[UserId] = @p_UserId,
	[OrderDate] = @p_OrderDate,
	[ShipAddr1] = @p_ShipAddr1,
	[ShipAddr2] = @p_ShipAddr2,
	[ShipCity] = @p_ShipCity,
	[ShipState] = @p_ShipState,
	[ShipZip] = @p_ShipZip,
	[ShipCountry] = @p_ShipCountry,
	[BillAddr1] = @p_BillAddr1,
	[BillAddr2] = @p_BillAddr2,
	[BillCity] = @p_BillCity,
	[BillState] = @p_BillState,
	[BillZip] = @p_BillZip,
	[BillCountry] = @p_BillCountry,
	[Courier] = @p_Courier,
	[TotalPrice] = @p_TotalPrice,
	[BillToFirstName] = @p_BillToFirstName,
	[BillToLastName] = @p_BillToLastName,
	[ShipToFirstName] = @p_ShipToFirstName,
	[ShipToLastName] = @p_ShipToLastName,
	[AuthorizationNumber] = @p_AuthorizationNumber,
	[Locale] = @p_Locale
WHERE
	[OrderId] = @p_OrderId

--endregion

GO

--region [dbo].[CSLA_Order_Delete]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith 5.0.0.0
-- Procedure Name: [dbo].[CSLA_Order_Delete]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Order_Delete]
	@p_OrderId int
AS

SET NOCOUNT ON

DELETE FROM
    [dbo].[Orders]
WHERE
	[OrderId] = @p_OrderId

--endregion

GO

--region [dbo].[CSLA_Order_Select]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith 5.0.0.0
-- Procedure Name: [dbo].[CSLA_Order_Select]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Order_Select]
	@p_OrderId int = NULL,
	@p_UserId varchar(20) = NULL,
	@p_OrderDate datetime = NULL,
	@p_ShipAddr1 varchar(80) = NULL,
	@p_ShipAddr2 varchar(80) = NULL,
	@p_ShipCity varchar(80) = NULL,
	@p_ShipState varchar(80) = NULL,
	@p_ShipZip varchar(20) = NULL,
	@p_ShipCountry varchar(20) = NULL,
	@p_BillAddr1 varchar(80) = NULL,
	@p_BillAddr2 varchar(80) = NULL,
	@p_BillCity varchar(80) = NULL,
	@p_BillState varchar(80) = NULL,
	@p_BillZip varchar(20) = NULL,
	@p_BillCountry varchar(20) = NULL,
	@p_Courier varchar(80) = NULL,
	@p_TotalPrice decimal(10, 2) = NULL,
	@p_BillToFirstName varchar(80) = NULL,
	@p_BillToLastName varchar(80) = NULL,
	@p_ShipToFirstName varchar(80) = NULL,
	@p_ShipToLastName varchar(80) = NULL,
	@p_AuthorizationNumber int = NULL,
	@p_Locale varchar(20) = NULL
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT
	[OrderId],
	[UserId],
	[OrderDate],
	[ShipAddr1],
	[ShipAddr2],
	[ShipCity],
	[ShipState],
	[ShipZip],
	[ShipCountry],
	[BillAddr1],
	[BillAddr2],
	[BillCity],
	[BillState],
	[BillZip],
	[BillCountry],
	[Courier],
	[TotalPrice],
	[BillToFirstName],
	[BillToLastName],
	[ShipToFirstName],
	[ShipToLastName],
	[AuthorizationNumber],
	[Locale]
FROM
    [dbo].[Orders]
WHERE
	([OrderId] = @p_OrderId OR @p_OrderId IS NULL)
	AND ([UserId] = @p_UserId OR @p_UserId IS NULL)
	AND ([OrderDate] = @p_OrderDate OR @p_OrderDate IS NULL)
	AND ([ShipAddr1] = @p_ShipAddr1 OR @p_ShipAddr1 IS NULL)
	AND ([ShipAddr2] = @p_ShipAddr2 OR @p_ShipAddr2 IS NULL)
	AND ([ShipCity] = @p_ShipCity OR @p_ShipCity IS NULL)
	AND ([ShipState] = @p_ShipState OR @p_ShipState IS NULL)
	AND ([ShipZip] = @p_ShipZip OR @p_ShipZip IS NULL)
	AND ([ShipCountry] = @p_ShipCountry OR @p_ShipCountry IS NULL)
	AND ([BillAddr1] = @p_BillAddr1 OR @p_BillAddr1 IS NULL)
	AND ([BillAddr2] = @p_BillAddr2 OR @p_BillAddr2 IS NULL)
	AND ([BillCity] = @p_BillCity OR @p_BillCity IS NULL)
	AND ([BillState] = @p_BillState OR @p_BillState IS NULL)
	AND ([BillZip] = @p_BillZip OR @p_BillZip IS NULL)
	AND ([BillCountry] = @p_BillCountry OR @p_BillCountry IS NULL)
	AND ([Courier] = @p_Courier OR @p_Courier IS NULL)
	AND ([TotalPrice] = @p_TotalPrice OR @p_TotalPrice IS NULL)
	AND ([BillToFirstName] = @p_BillToFirstName OR @p_BillToFirstName IS NULL)
	AND ([BillToLastName] = @p_BillToLastName OR @p_BillToLastName IS NULL)
	AND ([ShipToFirstName] = @p_ShipToFirstName OR @p_ShipToFirstName IS NULL)
	AND ([ShipToLastName] = @p_ShipToLastName OR @p_ShipToLastName IS NULL)
	AND ([AuthorizationNumber] = @p_AuthorizationNumber OR @p_AuthorizationNumber IS NULL)
	AND ([Locale] = @p_Locale OR @p_Locale IS NULL)

--endregion

GO

