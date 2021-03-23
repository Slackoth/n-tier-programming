CREATE DATABASE db_sales_pruchases_system;

--Category table
CREATE TABLE category(
	category_id INTEGER PRIMARY KEY IDENTITY,
	c_name VARCHAR(50) NOT NULL UNIQUE,
	description VARCHAR(255) NULL, 
	c_state BIT DEFAULT(1)
);

--Product table
CREATE TABLE product(
	product_id INTEGER PRIMARY KEY IDENTITY,
	category_id INTEGER NOT NULL,
	code VARCHAR(50) NULL,
	p_name VARCHAR(100) NOT NULL UNIQUE,
	sale_price DECIMAL(11, 2) NOT NULL ,
	stock INTEGER NOT NULL,
	p_description VARCHAR(255) NULL,
	img VARCHAR(20) NULL,
	p_state BIT DEFAULT(1),

	FOREIGN KEY (category_id) REFERENCES category(category_id)
);

--Person table
CREATE TABLE person(
	person_id INTEGER PRIMARY KEY IDENTITY,
	person_type VARCHAR(20) NOT NULL,
	ps_name VARCHAR(100) NOT NULL,
	document_type VARCHAR(20) NULL,
	document_num VARCHAR(20)  NULL,
	ps_address VARCHAR(70) NULL,
	phone VARCHAR(20) NULL,
	email VARCHAR(50) NULL
);

--Role table
CREATE TABLE role(
	role_id INTEGER PRIMARY KEY IDENTITY,
	r_name VARCHAR(30) NOT NULL UNIQUE,
	r_description VARCHAR(255) NULL,
	r_state BIT DEFAULT(1)
);

--User table
CREATE TABLE users(
	users_id INTEGER PRIMARY KEY IDENTITY,
	role_id INTEGER NOT NULL,
	u_name VARCHAR(100) NOT NULL,
	document_type VARCHAR(20) NULL,
	document_num VARCHAR(20)  NULL,
	ps_address VARCHAR(70) NULL,
	phone VARCHAR(20) NULL,
	email VARCHAR(50) NULL,
	u_password VARBINARY(MAX) NOT NULL,
	u_state BIT DEFAULT(1),

	FOREIGN KEY (role_id) REFERENCES role(role_id)
);

--Entries table
CREATE TABLE entries(
	entries_id INTEGER PRIMARY KEY IDENTITY,
	supplier_id INTEGER NOT NULL,
	users_id INTEGER NOT NULL,
	receipt_type VARCHAR(20) NOT NULL,
	receipt_serie VARCHAR(7) NULL,
	receipt_num VARCHAR(10) NOT NULL,
	e_date DATETIME NOT NULL,
	tax DECIMAL(4,2) NOT NULL,
	total DECIMAL(11,2) NOT NULL,
	e_state VARCHAR(20) NOT NULL,

	FOREIGN KEY (supplier_id) REFERENCES person(person_id),
	FOREIGN KEY (users_id) REFERENCES users(users_id)
);

--Entries detail table
CREATE TABLE entries_detail(
	entries_detail_id INTEGER PRIMARY KEY IDENTITY,
	entries_id INTEGER NOT NULL,
	product_id INTEGER NOT NULL,
	quantity INTEGER NOT NULL,
	price DECIMAL(11,2) NOT NULL,

	FOREIGN KEY (entries_id) REFERENCES entries(entries_id),
	FOREIGN KEY (product_id) REFERENCES product(product_id) ON DELETE CASCADE
);

--Sale table
CREATE TABLE sale(
	sale_id INTEGER PRIMARY KEY IDENTITY,
	client_id INTEGER NOT NULL,
	users_id INTEGER NOT NULL,
	receipt_type VARCHAR(20) NOT NULL,
	receipt_serie VARCHAR(7) NULL,
	receipt_num VARCHAR(10) NOT NULL,
	s_date DATETIME NOT NULL,
	tax DECIMAL(4,2) NOT NULL,
	total DECIMAL(11,2) NOT NULL,
	s_state VARCHAR(20) NOT NULL,

	FOREIGN KEY (client_id) REFERENCES person(person_id),
	FOREIGN KEY (users_id) REFERENCES users(users_id)
);

--Sale detail table
CREATE TABLE sale_detail(
	sale_detail_id INTEGER PRIMARY KEY IDENTITY,
	sale_id INTEGER NOT NULL,
	product_id INTEGER NOT NULL,
	quantity INTEGER NOT NULL,
	price DECIMAL(11,2) NOT NULL,
	disccount DECIMAL(11,2) NOT NULL,
	
	FOREIGN KEY (sale_id) REFERENCES sale(sale_id),
	FOREIGN KEY (product_id) REFERENCES product(product_id)
);