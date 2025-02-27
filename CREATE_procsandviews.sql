USE [AdventureWorksLT2017]
GO
/****** Object:  StoredProcedure [dbo].[AddCustomer]    Script Date: 2/17/2021 8:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCustomer]
	@CustomerID INT,
	@Title NVARCHAR(40),
	@LastName NVARCHAR(40),
	@MiddleName NVARCHAR (40),
	@FirstName NVARCHAR(40),
	@Suffix NVARCHAR(40),
	@CompanyName NVARCHAR(40),
	@EmailAddress NVARCHAR(40),
	@Phone NVARCHAR(40),
	@SalesPerson NVARCHAR(40),
	@PasswordHash NVARCHAR(40),
	@PasswordSalt NVARCHAR(40)
AS
	begin
	insert into SalesLT.Customer
	(Title, LastName, MiddleName, FirstName, Suffix, CompanyName, EmailAddress, Phone, SalesPerson, PasswordHash, PasswordSalt)
	values
	(@Title, @LastName, @MiddleName, @FirstName, @Suffix, @CompanyName, @EmailAddress, @Phone, @SalesPerson, @PasswordHash, @PasswordSalt)
	end

GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomer]    Script Date: 2/17/2021 8:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomer]
	@CustomerID INT,
	@AddressID INT
AS

delete from SalesLT.CustomerAddress
where AddressID = @AddressID and CustomerID = @CustomerID

delete from SalesLT.[Address]
where AddressID = @AddressID



--some customers have multiple addresses, the code above will delete only the selected address row, not all of them
--if no remaining addresses, safe to delete customer too

if (select count(CustomerID) from SalesLT.CustomerAddress where CustomerID = @CustomerID) = 0
begin
delete from SalesLT.Customer
where CustomerID = @CustomerID
end
GO
/****** Object:  StoredProcedure [dbo].[getAllCustomers]    Script Date: 2/17/2021 8:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAllCustomers]
as
BEGIN

SELECT c.CustomerID, c.Title, c.FirstName, c.MiddleName, c.LastName, c.Suffix, c.CompanyName, c.SalesPerson, c.EmailAddress, c.Phone, c.ModifiedDate,
ca.AddressID, ca.AddressType, 
a.AddressLine1, a.AddressLine2, a.City, a.CountryRegion, a.PostalCode, a.StateProvince
from SalesLT.Customer as c
inner join SalesLT.CustomerAddress as ca
on c.CustomerID = ca.CustomerID
inner join SalesLT.Address as a
on ca.AddressID = a.AddressID
end
GO
/****** Object:  StoredProcedure [dbo].[getAllProducts]    Script Date: 2/17/2021 8:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getAllProducts]
as
begin
SELECT p.ProductID, p.Name, p.ProductNumber, p.Color, p.StandardCost, p.ListPrice, p.Size, p.Weight, p.ProductCategoryID, p.ProductModelID, p.SellStartDate, p.SellEndDate, p.DiscontinuedDate, p.ThumbNailPhoto, p.ThumbnailPhotoFileName, p.ModifiedDate,
pm.Name as 'Model Name', pm.CatalogDescription,
pc.Name as 'Category Name',
pmpd.Culture, pmpd.ProductDescriptionID,
pd.Description
from SalesLT.Product as p
inner join SalesLT.ProductModel as pm
on p.ProductModelID = pm.ProductModelID
inner join SalesLT.ProductCategory as pc
on p.ProductCategoryID = pc.ProductCategoryID
inner join SalesLT.ProductModelProductDescription as pmpd
on pm.ProductModelID = pmpd.ProductModelID
inner join SalesLT.ProductDescription as pd
on pmpd.ProductDescriptionID = pd.ProductDescriptionID
end
GO
/****** Object:  StoredProcedure [dbo].[SearchCustomers]    Script Date: 2/17/2021 8:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SearchCustomers]
	@Name nvarchar(40)
AS
SELECT c.CustomerID, c.Title, c.FirstName, c.MiddleName, c.LastName, c.Suffix, c.CompanyName, c.SalesPerson, c.EmailAddress, c.Phone, c.ModifiedDate,
ca.AddressID, ca.AddressType, 
a.AddressLine1, a.AddressLine2, a.City, a.CountryRegion, a.PostalCode, a.StateProvince
from SalesLT.Customer as c
inner join SalesLT.CustomerAddress as ca
on c.CustomerID = ca.CustomerID
inner join SalesLT.Address as a
on ca.AddressID = a.AddressID
where c.[FirstName] LIKE @Name+'%' or c.[LastName] LIKE @Name+'%'
GO
/****** Object:  StoredProcedure [dbo].[SearchProducts]    Script Date: 2/17/2021 8:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SearchProducts]
	@Name nvarchar(40)
AS
SELECT p.ProductID, p.Name, p.ProductNumber, p.Color, p.StandardCost, p.ListPrice, p.Size, p.Weight, p.ProductCategoryID, p.ProductModelID, p.SellStartDate, p.SellEndDate, p.DiscontinuedDate, p.ThumbNailPhoto, p.ThumbnailPhotoFileName, p.ModifiedDate,
pm.Name as 'Model Name', pm.CatalogDescription,
pc.Name as 'Category Name',
pmpd.Culture, pmpd.ProductDescriptionID,
pd.Description
from SalesLT.Product as p
inner join SalesLT.ProductModel as pm
on p.ProductModelID = pm.ProductModelID
inner join SalesLT.ProductCategory as pc
on p.ProductCategoryID = pc.ProductCategoryID
inner join SalesLT.ProductModelProductDescription as pmpd
on pm.ProductModelID = pmpd.ProductModelID
inner join SalesLT.ProductDescription as pd
on pmpd.ProductDescriptionID = pd.ProductDescriptionID
where p.[Name] LIKE @Name+'%'
GO
/****** Object:  StoredProcedure [dbo].[UpdateAddresses]    Script Date: 2/17/2021 8:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateAddresses]
@AddressID INT,
	@AddressLine1 NVARCHAR(40),
	@AddressLine2 NVARCHAR(40),
	@City NVARCHAR (40),
	@StateProvince NVARCHAR(40),
	@CountryRegion NVARCHAR(40),
	@PostalCode NVARCHAR(40)
AS
if @AddressID = 0
insert into SalesLT.Address
(AddressLine1, AddressLine2, City, StateProvince, CountryRegion, PostalCode)
values
(@AddressLine1, @AddressLine2, @City, @StateProvince, @CountryRegion, @PostalCode)
else
update SalesLT.Address
set
AddressLine1=@AddressLine1,
AddressLine2=@AddressLine2,
City=@City,
StateProvince=@StateProvince,
CountryRegion=@CountryRegion,
PostalCode=@PostalCode
where AddressID = @AddressID
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 2/17/2021 8:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomer]
	@CustomerID INT,
	@Title NVARCHAR(40),
	@LastName NVARCHAR(40),
	@MiddleName NVARCHAR (40),
	@FirstName NVARCHAR(40),
	@Suffix NVARCHAR(40),
	@CompanyName NVARCHAR(40),
	@EmailAddress NVARCHAR(40),
	@Phone NVARCHAR(40),
	@SalesPerson NVARCHAR(40),
	@PasswordHash NVARCHAR(40),
	@PasswordSalt NVARCHAR(40),
	@AddressID INT,
	@AddressType NVARCHAR(40),
	@AddressLine1 NVARCHAR(40),
	@AddressLine2 NVARCHAR(40),
	@City NVARCHAR(40),
	@StateProvince NVARCHAR(40),
	@CountryRegion NVARCHAR(40),
	@PostalCode NVARCHAR(40)
AS
----------

if @CustomerID = 0
begin
insert into SalesLT.Customer
(Title, LastName, MiddleName, FirstName, Suffix, CompanyName, EmailAddress, Phone, SalesPerson, PasswordHash, PasswordSalt)
values
(@Title, @LastName, @MiddleName, @FirstName, @Suffix, @CompanyName, @EmailAddress, @Phone, @SalesPerson, @PasswordHash, @PasswordSalt)

insert into SalesLT.Address
(AddressLine1, AddressLine2, City, StateProvince, CountryRegion, PostalCode)
values
(@AddressLine1, @AddressLine2, @City, @StateProvince, @CountryRegion, @PostalCode)

insert into SalesLT.CustomerAddress
(CustomerID, AddressID, AddressType)
values
((select max(CustomerID) from SalesLT.Customer), (select max(AddressID) from SalesLT.Address), @AddressType)

end

-----------

else
begin
update SalesLT.Customer
set
Title = @Title,
LastName = @LastName,
FirstName = @FirstName,
MiddleName = @MiddleName,
Suffix = @Suffix,
CompanyName = @CompanyName,
EmailAddress = @EmailAddress,
Phone = @Phone,
SalesPerson = @SalesPerson,
PasswordHash = @PasswordHash,
PasswordSalt = @PasswordSalt
where CustomerID = @CustomerID

update SalesLT.CustomerAddress
set
AddressType = @AddressType
where CustomerID = @CustomerID

update SalesLT.Address
set
AddressLine1 = @AddressLine1,
AddressLine2 = @AddressLine2,
City = @City,
StateProvince = @StateProvince,
CountryRegion = @CountryRegion,
PostalCode = @PostalCode
where AddressID = @AddressID
end
GO
/****** Object:  StoredProcedure [dbo].[uspLogError]    Script Date: 2/17/2021 8:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- uspLogError logs error information in the ErrorLog table about the 
-- error that caused execution to jump to the CATCH block of a 
-- TRY...CATCH construct. This should be executed from within the scope 
-- of a CATCH block otherwise it will return without inserting error 
-- information. 
CREATE PROCEDURE [dbo].[uspLogError] 
    @ErrorLogID [int] = 0 OUTPUT -- contains the ErrorLogID of the row inserted
AS                               -- by uspLogError in the ErrorLog table
BEGIN
    SET NOCOUNT ON;

    -- Output parameter value of 0 indicates that error 
    -- information was not logged
    SET @ErrorLogID = 0;

    BEGIN TRY
        -- Return if there is no error information to log
        IF ERROR_NUMBER() IS NULL
            RETURN;

        -- Return if inside an uncommittable transaction.
        -- Data insertion/modification is not allowed when 
        -- a transaction is in an uncommittable state.
        IF XACT_STATE() = -1
        BEGIN
            PRINT 'Cannot log error since the current transaction is in an uncommittable state. ' 
                + 'Rollback the transaction before executing uspLogError in order to successfully log error information.';
            RETURN;
        END

        INSERT [dbo].[ErrorLog] 
            (
            [UserName], 
            [ErrorNumber], 
            [ErrorSeverity], 
            [ErrorState], 
            [ErrorProcedure], 
            [ErrorLine], 
            [ErrorMessage]
            ) 
        VALUES 
            (
            CONVERT(sysname, CURRENT_USER), 
            ERROR_NUMBER(),
            ERROR_SEVERITY(),
            ERROR_STATE(),
            ERROR_PROCEDURE(),
            ERROR_LINE(),
            ERROR_MESSAGE()
            );

        -- Pass back the ErrorLogID of the row inserted
        SET @ErrorLogID = @@IDENTITY;
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred in stored procedure uspLogError: ';
        EXECUTE [dbo].[uspPrintError];
        RETURN -1;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[uspPrintError]    Script Date: 2/17/2021 8:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- uspPrintError prints error information about the error that caused 
-- execution to jump to the CATCH block of a TRY...CATCH construct. 
-- Should be executed from within the scope of a CATCH block otherwise 
-- it will return without printing any error information.
CREATE PROCEDURE [dbo].[uspPrintError] 
AS
BEGIN
    SET NOCOUNT ON;

    -- Print error information. 
    PRINT 'Error ' + CONVERT(varchar(50), ERROR_NUMBER()) +
          ', Severity ' + CONVERT(varchar(5), ERROR_SEVERITY()) +
          ', State ' + CONVERT(varchar(5), ERROR_STATE()) + 
          ', Procedure ' + ISNULL(ERROR_PROCEDURE(), '-') + 
          ', Line ' + CONVERT(varchar(5), ERROR_LINE());
    PRINT ERROR_MESSAGE();
END;
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Logs error information in the ErrorLog table about the error that caused execution to jump to the CATCH block of a TRY...CATCH construct. Should be executed from within the scope of a CATCH block otherwise it will return without inserting error information.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'PROCEDURE',@level1name=N'uspLogError'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Output parameter for the stored procedure uspLogError. Contains the ErrorLogID value corresponding to the row inserted by uspLogError in the ErrorLog table.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'PROCEDURE',@level1name=N'uspLogError', @level2type=N'PARAMETER',@level2name=N'@ErrorLogID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Prints error information about the error that caused execution to jump to the CATCH block of a TRY...CATCH construct. Should be executed from within the scope of a CATCH block otherwise it will return without printing any error information.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'PROCEDURE',@level1name=N'uspPrintError'
GO
