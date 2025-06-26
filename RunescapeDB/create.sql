USE osrs;

DROP TABLE IF EXISTS runescapeItems;
DROP TABLE IF EXISTS runescapeSkills;

CREATE TABLE runescapeItems (
	id int primary key AUTO_INCREMENT,
	name varchar(50) not null,
	skill varchar(20) not null,
	membership varchar(7) not null,
	level int not null,
	exp double not null
);

CREATE TABLE runescapeSkills (
	id int primary key AUTO_INCREMENT,
	name varchar(40) not null,
	membership varchar(6) not null
);

ALTER USER 'casey'@'%' IDENTIFIED WITH mysql_native_password BY '9139800216';
FLUSH PRIVILEGES;