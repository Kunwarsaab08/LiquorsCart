--Function to get current value of sequence
CREATE FUNCTION getCurrentIdentity(@tbl_name varchar(100))
RETURNS BIGINT
AS
BEGIN
	DECLARE @result AS BIGINT;
	SELECT @result = CAST(current_value AS BIGINT) FROM sys.sequences WHERE name = @tbl_name + '_Sequence' ;	
	RETURN @result;
END;


