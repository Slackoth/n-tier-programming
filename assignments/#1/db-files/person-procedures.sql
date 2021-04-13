CREATE OR ALTER PROC list_person
AS
SELECT p_name as Nombre, lastname as Apellido, age as Edad, phone as Tel, pr.pr_name as Rol
FROM person p INNER JOIN person_role pr 
ON p.id_role = pr.id;
GO;

CREATE OR ALTER  PROC insert_person
@name VARCHAR(100), @lastname VARCHAR(100), @age INTEGER, @phone VARCHAR(20)
AS
INSERT INTO person(p_name,lastname,age,phone) VALUES(@name,@lastname,@age,@phone)
GO;

EXEC insert_person @name='Henry', @lastname='Cavill', @age=45, @phone='7777-8888';
EXEC list_person;