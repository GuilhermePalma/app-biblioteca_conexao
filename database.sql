drop database if exists system_users;

create database if not exists system_users;

use system_users;

create table users(
id int primary key not null auto_increment,
name varchar(70) not null,
cargo varchar(70) not null,
date date not null
);

describe users;

use system_users;
INSERT INTO users(name, cargo, date) VALUES
("João","Desempregado", "2021-06-11"),
("Guilherme","Estudante", "2000-06-05"),
("Juliana","Empresaroa", "1978-03-01"),
("Joana","Gerente", "2021-06-12");

use system_users;
SELECT * FROM USERS ORDER BY id asc;