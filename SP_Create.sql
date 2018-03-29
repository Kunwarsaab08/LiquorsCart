--SP is used to get next value of any sequence.
ALTER PROCEDURE [dbo].[getNextIdentity]
	@tbl_name varchar(100),
	@result as BIGINT OUTPUT
AS
BEGIN
	DECLARE @Sql as varchar(100);
	SET @Sql='SELECT NEXT VALUE FOR ' + @tbl_name + '_Sequence';	
	EXECUTE(@Sql);
	EXEC sp_executesql @sql,@result OUTPUT;
END;


Declare @rslt bigint 
Exec [dbo].[getNextIdentity] @tbl_name='SEORepository',@result = @rslt
print @rslt

DROP PROCEDURE dbo.[getNextIdentity]