DROP DATABASE IF EXISTS doacao;
 
CREATE DATABASE doacao;
USE doacao;
 
CREATE TABLE pessoa_doador(
	id_doador INT,
	cpf_doador INT NOT NULL,
    nome VARCHAR(150) NOT NULL,
    endereco VARCHAR(200) NOT NULL,
    telefone VARCHAR(11) NOT NULL
	);
    
    ALTER TABLE pessoa_doador
    ADD CONSTRAINT pk_id_cpf_doador
    PRIMARY KEY (id_doador, cpf_doador);

SELECT * FROM pessoa_doador;

CREATE TABLE pessoa_recebedor(
	id_recebedor INT,
	cpf_recebedor INT NOT NULL,
    nome VARCHAR(150) NOT NULL,
    endereco VARCHAR(200) NOT NULL,
    telefone VARCHAR(11) NOT NULL
	);
    
	ALTER TABLE pessoa_recebedor
    ADD CONSTRAINT pk_id_cpf_recebedor
    PRIMARY KEY (id_recebedor, cpf_recebedor);

SELECT * FROM pessoa_recebedor;
 
CREATE TABLE cadastro_pedido(
	registro INT AUTO_INCREMENT PRIMARY KEY,
   
	doador_cpf INT,
    CONSTRAINT fk_cpf_doador_pedido
    FOREIGN KEY (doador_cpf)
    REFERENCES pessoa_doador(cpf_doador),
    
    recebedor_cpf INT,
	CONSTRAINT fk_cpf_recebedor_pedido
    FOREIGN KEY (recebedor_cpf)
    REFERENCES pessoa_recebedor(cpf_recebedor),
	
    categoria TEXT NOT NULL,
    subcategoria_1 TEXT NOT NULL,
    subcategoria_2 TEXT NOT NULL,
    subcategoria_3 TEXT,
    descricao LONGTEXT,
    status TINYINT NOT NULL
);
 
CREATE TABLE cadastro_doacao(
	registro INT AUTO_INCREMENT PRIMARY KEY,
    
    doador2_cpf INT,
    CONSTRAINT fk_cpf_doador_doacao
    FOREIGN KEY (doador2_cpf)
    REFERENCES pessoa_doador(cpf_doador),
    
    recebedor_cpf INT,
	CONSTRAINT fk_cpf_recebedor_doacao
    FOREIGN KEY (recebedor_cpf)
    REFERENCES pessoa_recebedor(cpf_recebedor),
	
    categoria TEXT NOT NULL,
    subcategoria_1 TEXT NOT NULL,
    subcategoria_2 TEXT NOT NULL,
    subcategoria_3 TEXT,
    descricao LONGTEXT,
    status TINYINT NOT NULL
)