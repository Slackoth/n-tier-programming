CREATE TABLE person_role(
	id INT PRIMARY KEY IDENTITY,
	role_name VARCHAR(50) NOT NULL,
	role_description VARCHAR(255) NULL,
	role_state BIT NOT NULL DEFAULT(1)
);

CREATE TABLE person(
	id INT PRIMARY KEY IDENTITY,
	person_name VARCHAR(250) NOT NULL,
	person_lastname VARCHAR(250) NOT NULL,
	age INT NOT NULL,
	phone VARCHAR(20) NOT NULL,
	id_role INT NOT NULL,

	FOREIGN KEY (id_role) REFERENCES person_role(id)
);

--Visual Studio tiraba una excepción "A potentially dangerous 
--Request.Path value was detected from the client" por tener como PRIMARY KEY el campo
--de nombre
CREATE TABLE movie(
	id INT PRIMARY KEY IDENTITY,
	movie_name VARCHAR(250),
	movie_date DATETIME NOT NULL,
	duration TIME NOT NULL,
	category VARCHAR(250) NULL,
	studio VARCHAR(250) NOT NULL,
	director VARCHAR(250) NOT NULL,
	genre VARCHAR(250) NOT NULL
);

CREATE TABLE premier_access(
	id INT PRIMARY KEY IDENTITY,
	movie_id INT NOT NULL,
	person_id INT NOT NULL,

	FOREIGN KEY (movie_id) REFERENCES movie(id),
	FOREIGN KEY (person_id) REFERENCES person(id),
);