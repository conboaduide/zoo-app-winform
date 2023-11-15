create database ZooManagement

use ZooManagement

create table [user] (
	id int identity(1,1) primary key,
	username varchar(20), 
	firstname varchar(20),
	lastname varchar(20),
	sex bit,
	dateOfBirth datetime2(6),
	address varchar(30),
	email varchar(30),
	nationality varchar(20),
	phone varchar(20),
	password varchar(20),
	created_date datetime2(6) default getdate(),
	status bit,
	avatar_url varchar(max),
	reset_token varchar(30),
)
create table [role](
	 id int primary key identity(1,1),
	name varchar(20)
)

create table [user_role](
	id int primary key identity(1,1),
	user_id int foreign key references [user](id),
	role_id int foreign key references [role](id),
)

create table ticket (
	id int primary key identity(1,1),
	description varchar(50),
	img_url varchar(max),
	name varchar(20),
	price float,
	status bit,
	type varchar(20),
	created_date datetime2(6) default getDate(),
)

create table [order](
	id int primary key identity(1,1),
	payment_method varchar(20),
	status bit,
	total float,
	customer_id int foreign key references [user](id),
	created_date datetime2(6) default getDate(),
)

create table order_detail(
	id int primary key identity(1,1),
	is_checked bit,
	checked_by int foreign key references [user](id),
	orderId int foreign key references [user](id),
	ticketId int foreign key references ticket(id),
)

create table animal(
 id int primary key identity(1,1),
 arival_date datetime2(6),
 created_date datetime2(6),
 date_of_birth datetime2(6),
 date_of_death datetime2(6),
 img_url varchar(max),
 name varchar(20),
 origin varchar(20),
 sex bit,
 created_by int foreign key references [user](id),
)

create table animal_trainer_assignor(
	id int primary key identity(1,1),
	animal_id int foreign key references animal(id),
	assigned_by int foreign key references [user](id),
	trainer_id int foreign key references [user](id),
)
create table food (
	id int primary key identity(1,1),
	name varchar(20),
	type varchar(20),
	created_date datetime2(6) default getDate(),
	created_by int foreign key references [user](id)
)
create table diet (
	id int primary key identity(1,1),
	created_date datetime2(6),
	type varchar(20),
	created_by int foreign key references [user](id),
)
create table diet_food(
	id int primary key identity(1,1),
	diet_id int foreign key references diet(id),
	food_id int foreign key references food(id),
)
create table feeding_schedule (
	id int primary key identity(1,1),
	conformation_img_url varchar(max),
	created_date datetime2(6),
	fed bit,
	fed_time datetime2(6),
	feeding_time datetime2(6),
	animal_id int foreign key references animal(id),
	diet_id int foreign key references diet(id),
)