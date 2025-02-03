-- create database Schooll
-- use Schooll

create table Teachers(
    Id int primary key identity, 
    Identification bigint,
    Name varchar(100),
    User_login varchar(100),
    Password_login varchar(100),
    Date_create DATETIME,
    Fk_id_user_create int null FOREIGN KEY REFERENCES Teachers(Id),
    Date_update DATETIME null,
    Fk_id_user_update int null FOREIGN KEY REFERENCES Teachers(Id),
    State bit 
)


create table Courses(
    Id int primary key identity, 
    Name varchar(100),
    Date_create DATETIME,
    TeachersId int,
    Fk_id_user_create int,
    Date_update DATETIME null,
    Fk_id_user_update int null,
    State bit 
)

create table Students(
    Id int primary key identity, 
    Identification bigint,
    Name varchar(100),
    Age int,
    User_login varchar(100),
    Password_login varchar(100),
    Fk_id_courses int FOREIGN KEY REFERENCES Courses(Id),
    Date_create DATETIME,
    Fk_id_user_create int FOREIGN KEY REFERENCES Teachers(Id),
    Date_update DATETIME null,
    Fk_id_user_update int null FOREIGN KEY REFERENCES Teachers(Id),
    State bit 
)

create table Ratings(
    Id int primary key identity, 
    Ratings DECIMAL,
    Fk_id_courses int FOREIGN KEY REFERENCES Courses(Id),
    Fk_id_students int FOREIGN KEY REFERENCES Students(Id),
    Date_create DATETIME,
    Fk_id_user_create int FOREIGN KEY REFERENCES Teachers(Id),
    Date_update DATETIME null,
    Fk_id_user_update int null FOREIGN KEY REFERENCES Teachers(Id),
    State bit 
)

insert into Teachers(Identification,Name,User_login,Password_login,Date_create,State) values(1,'admin','admin','admin','2024-01-01',1)