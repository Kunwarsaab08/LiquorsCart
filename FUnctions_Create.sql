--Function to get current value of sequence
CREATE FUNCTION getCurrentIdentity(@tbl_name varchar(100))
AS
BEGIN

IF @tbl_name <> '' and @tbl_name is not null
   RETURN IDENT_CURRENT(@tbl_name + '_Sequence')
ELSE
   RETURN NULL
END