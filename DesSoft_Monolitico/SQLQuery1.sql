create database GestionTarea
use GestionTarea

create table Tareas(
TareaId int identity (1,1) primary key,
Titulo varchar(50),
FechaLimite datetime, --fechacreacion
Estado bit NOT NULL DEFAULT 0
)

