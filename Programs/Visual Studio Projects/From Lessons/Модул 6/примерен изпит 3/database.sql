create database buhtig_source_control;
use buhtig_source_control;

create table users
(
	id int(11) primary key auto_increment,
    username varchar(30) not null unique,
    password varchar(30) not null,
    email varchar(50) not null
);

create table repositories
(
	id int(11) primary key auto_increment,
    name varchar(50) not null
);

create table repositories_contributors
(
	repository_id int(11),
    contributor_id int(11),
    foreign key(repository_id) references repositories(id),
    foreign key(contributor_id) references users(id)
);

create table issues
(
	id int(11) primary key auto_increment,
    title varchar(255) not null,
    issue_status varchar(6) not null,
    repository_id int(11) not null,
    assignee_id int(11) not null,
    foreign key(repository_id) references repositories(id),
    foreign key(assignee_id) references users(id)
);

create table commits
(
	id int(11) primary key auto_increment,
    message varchar(255) not null,
    issue_id int(11),
    repository_id int(11) not null,
    contributor_id int(11) not null,
    foreign key(issue_id) references issues(id),
	foreign key(repository_id) references repositories(id),
    foreign key(contributor_id) references users(id)
);


create table files
(
	id int(11) primary key auto_increment,
    name varchar(100) not null,
    size decimal(10,2) not null,
    parent_id int(11),
    commit_id int(11) not null,
    foreign key(parent_id) references files(id),
    foreign key(commit_id) references commits(id)
);