Drop database colonial_journey_management_system_db;
CREATE database colonial_journey_management_system_db;
use colonial_journey_management_system_db;
CREATE TABLE planets 
(
	id int(11) primary key auto_increment,
    name varchar(30) not null
);
CREATE TABLE spaceports
(
	id int(11) primary key auto_increment,
    name varchar(50) not null,
    planet_id int(11),
    foreign key(planet_id) references planets(id)
);
CREATE TABLE spaceships
(
	id int(11) primary key auto_increment,
    name varchar(50) not null,
    manufacturer varchar(30) not null,
    light_speed_rate int(11) default 0
);
CREATE TABLE colonists
(
	id int(11) primary key auto_increment,
    first_name varchar(20) not null,
    last_name varchar(20) not null,
    ucn char(10) NOT NULL UNIQUE,
    birth_date DATE not null
);
create table journeys
(
	id int(11) primary key auto_increment,
    journey_start DATETIME not null,
    journey_end DATETIME not null,
    purpose ENUM('Medical', 'Technical', 'Educational', 'Military'),
    destination_spaceport_id int(11),
    spaceship_id int(11),
    foreign key(destination_spaceport_id) references spaceports(id),
    foreign key(spaceship_id) references spaceships(id)
);
CREATE TABLE travel_cards
(
	id int(11) primary key auto_increment,
    card_number char(10) not null unique,
    job_during_journey enum('Pilot', 'Engineer', 'Trooper', 'Cleaner', 'Cook'),
    colonist_id int(11),
    journey_id int(11),
    foreign key(colonist_id) references colonists(id),
    foreign key(journey_id) references journeys(id)
);