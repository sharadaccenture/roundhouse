CREATE OR REPLACE PROCEDURE usp_SelectTimmy 
 ( v_ID OUT Number )
AS
BEGIN
SELECT ID INTO v_ID FROM vw_Dude;
END
;