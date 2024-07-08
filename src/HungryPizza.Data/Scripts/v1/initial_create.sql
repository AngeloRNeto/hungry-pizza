create table if not exists status_pedido (
	id integer primary key not null,
	descricao varchar not null
);

create table if not exists endereco (
	id serial primary key not null,
	rua varchar not null,
	numero varchar not null,
	bairro varchar not null,
	complemento varchar null
);

create table if not exists pedido (
	id serial primary key not null,
	codigo varchar(12) not null,
	valor numeric(10,5) not null,
	observacao varchar(300) null,
	status_pedido_id integer not null,
	endereco_id integer not null,
    foreign key (status_pedido_id) references status_pedido (id),
	foreign key (endereco_id) references endereco (id)
);

create table if not exists opcao_pizza (
	id serial primary key not null,
	descricao_sabor varchar(150) not null,
	valor numeric(10,5) not null
);

create table if not exists pedido_opcao_pizza (
    id serial not null,
	id_pedido integer not null,
	id_opcao_pizza integer not null,
	id_opcao_pizza_2 integer null
);


insert into status_pedido values
(1, 'Registrado'),
(2, 'Em Andamento de Preparo'),
(3, 'Saiu para a entrega');

insert into opcao_pizza (descricao_sabor,valor) values
('3 Queijos', 50.00),
('Frango com requeijão', 59.99),
('Mussarela', 42.50),
('Calabresa', 42.50),
('Pepperoni', 55.00),
('Portuguesa', 45.00),
('Veggie', 59.99);
