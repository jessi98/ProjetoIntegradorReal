DROP DATABASE IF EXISTS doacao;
 
CREATE DATABASE doacao;
USE doacao;
 
CREATE TABLE pessoa_doador(
	id_doador INT AUTO_INCREMENT UNIQUE,
	cpf_doador BIGINT PRIMARY KEY NOT NULL,
    nome VARCHAR(150) NOT NULL,
    endereco VARCHAR(200) NOT NULL,
    telefone VARCHAR(11) NOT NULL
	);

SELECT * FROM pessoa_doador;

CREATE TABLE pessoa_recebedor(
	id_recebedor INT AUTO_INCREMENT UNIQUE,
	cpf_recebedor BIGINT PRIMARY KEY NOT NULL,
    nome VARCHAR(150) NOT NULL,
    endereco VARCHAR(200) NOT NULL,
    telefone VARCHAR(11) NOT NULL
	);
    
SELECT * FROM pessoa_recebedor;
 
CREATE TABLE cadastro_pedido(
	registro INT AUTO_INCREMENT PRIMARY KEY,
   
	doador_cpf BIGINT,
    CONSTRAINT fk_cpf_doador_pedido
    FOREIGN KEY (doador_cpf)
    REFERENCES pessoa_doador(cpf_doador),
    
    recebedor_cpf BIGINT,
	CONSTRAINT fk_cpf_recebedor_pedido
    FOREIGN KEY (recebedor_cpf)
    REFERENCES pessoa_recebedor(cpf_recebedor),
	
    categoria VARCHAR(25) NOT NULL,
    subcategoria_1 VARCHAR(25) NOT NULL,
    subcategoria_2 VARCHAR(25) NOT NULL,
    subcategoria_3 VARCHAR(25),
    descricao VARCHAR(250),
    status TINYINT NOT NULL
);

SELECT * FROM cadastro_pedido;

CREATE TABLE cadastro_doacao(
	registro INT AUTO_INCREMENT PRIMARY KEY,
    
    doador2_cpf BIGINT,
    CONSTRAINT fk_cpf_doador_doacao
    FOREIGN KEY (doador2_cpf)
    REFERENCES pessoa_doador(cpf_doador),
    
    recebedor_cpf BIGINT,
	CONSTRAINT fk_cpf_recebedor_doacao
    FOREIGN KEY (recebedor_cpf)
    REFERENCES pessoa_recebedor(cpf_recebedor),
	
    categoria VARCHAR(25) NOT NULL,
    subcategoria_1 VARCHAR(25) NOT NULL,
    subcategoria_2 VARCHAR(25) NOT NULL,
    subcategoria_3 VARCHAR(25),
    descricao VARCHAR(250),
    status TINYINT NOT NULL
);

SELECT * FROM cadastro_doacao;