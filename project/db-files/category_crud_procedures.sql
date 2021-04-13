--List category procedure
CREATE PROC list_category
AS
SELECT category_id as ID, c_name  as Nombre, description as Descripcion, c_state as Estado
FROM category ORDER BY category_id DESC
GO;

--Search category procedure
CREATE PROC search_category
@value VARCHAR(50) AS
SELECT category_id as ID, c_name  as Nombre, description as Descripcion, c_state as Estado
FROM category WHERE c_name LIKE '%' + @value + '%' 
OR description LIKE '%' + @value + '%' ORDER BY c_name ASC 
GO;

--Insert category procedure
CREATE PROC insert_category
@name VARCHAR(50), @description VARCHAR(255) AS
INSERT INTO category(c_name, description) VALUES(@name,@description)
GO;

--Update catgory procedure
CREATE PROC update_category
@id INT, @name VARCHAR(50), @description VARCHAR(255) AS
UPDATE category SET c_name = @name, description = @description
WHERE category_id = @id
GO;

--Delete category procedure
CREATE PROC delete_category
@id INT AS
DELETE FROM category WHERE category_id = @id
GO;

--Activate category procedure
CREATE PROC activate_category
@id INT AS
UPDATE category SET c_state = 1
WHERE category_id = @id
GO;

--Deactivate category procedure
CREATE PROC deactivate_category
@id INT AS
UPDATE category SET c_state = 0
GO;

--Exists category procedure
CREATE PROC category_exists
@value VARCHAR(100), @exists BIT OUTPUT AS
IF EXISTS(SELECT c_name FROM category WHERE c_name = LTRIM(RTRIM(@value)))
BEGIN
SET @exists = 1
END
ELSE
BEGIN
SET @exists = 0
END
GO;