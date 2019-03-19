DROP TABLE IF EXISTS runescapeItems;

CREATE TABLE runescapeItems (
	id int primary key AUTO_INCREMENT,
	name varchar(30) not null,
	skill varchar(20) not null,
	membership varchar(6) not null,
	level int not null,
	exp double not null
);

CREATE TABLE runescapeSkills (
	id int primary key AUTO_INCREMENT,
	name varchar(20) not null,
	membership varchar(6) not null
);