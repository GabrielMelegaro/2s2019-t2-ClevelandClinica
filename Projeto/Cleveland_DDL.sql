create database Cleveland_clinica;

use Cleveland_clinica

create table Medicos
(
	IdMedico int primary key identity
	,Nome varchar (255) not null
	,DataNasc date not null
	,CRM varchar(999) not null
)