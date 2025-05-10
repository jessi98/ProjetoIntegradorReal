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

INSERT INTO pessoa_doador (cpf_doador, nome, endereco, telefone)
VALUES(0, 'admin', 'admin', '0');

SELECT * FROM pessoa_doador;

CREATE TABLE pessoa_recebedor(
	id_recebedor INT AUTO_INCREMENT UNIQUE,
	cpf_recebedor BIGINT PRIMARY KEY NOT NULL,
    nome VARCHAR(150) NOT NULL,
    endereco VARCHAR(200) NOT NULL,
    telefone VARCHAR(11) NOT NULL
	);
    
INSERT INTO pessoa_recebedor (cpf_recebedor, nome, endereco, telefone)
VALUES(0, 'admin', 'admin', '0');

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
    status TINYINT NOT NULL DEFAULT 0
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
    status TINYINT NOT NULL DEFAULT 0
);

SELECT 'cadastro_doacao' AS origem, registro FROM cadastro_doacao dc
JOIN pessoa_doador d ON dc.doador2_cpf = d.cpf_doador
JOIN pessoa_recebedor r ON dc.recebedor_cpf = r.cpf_recebedor
WHERE d.nome = "Theodoro" AND d.telefone = "1547" AND dc.categoria = "Roupas" AND r.nome = "Theodoro" AND r.telefone ="515" AND status = 1
union all
SELECT 'cadastro_pedido' AS origem, registro FROM cadastro_pedido dc
JOIN pessoa_doador d ON dc.doador_cpf = d.cpf_doador
JOIN pessoa_recebedor r ON dc.recebedor_cpf = r.cpf_recebedor
WHERE d.nome = "Theodoro" AND d.telefone = "1547" AND dc.categoria = "Cesta Básica" AND r.nome = "Theodoro" AND r.telefone ="515" AND status = 1;


