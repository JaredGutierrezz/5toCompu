create database TECVJAGQ
use TECVJAGQ

CREATE TABLE Usuario(
Usuario VARCHAR(25) PRIMARY KEY NOT NULL,
Contraseña VARCHAR(25),
Roll VARCHAR(25)
)

INSERT Usuario VALUES
('guti64@.com','1234','Administrador')
INSERT Usuario VALUES
('MariO@.com','12346','Usuario')
INSERT Usuario VALUES
('Jose@com','12347','Secretario')

drop table Usuario
select *from Usuario