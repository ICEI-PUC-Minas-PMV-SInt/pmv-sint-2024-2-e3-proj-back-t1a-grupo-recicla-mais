create database RMDatabase;
use RMDatabase;

Drop database RMDatabase;

CREATE TABLE Usuario ( 
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL, 
	nome VARCHAR(255) NOT NULL, 
	sobrenome VARCHAR(255), 
	data_nascimento DATE, 
	pontuacao INT, 
	cpf VARCHAR(20), 
	estado ENUM( 'AC', 'AL', 'AP', 'AM', 'BA', 'CE', 'DF', 'ES', 'GO', 'MA', 'MT', 'MS', 'MG', 'PA', 'PB', 'PR', 'PE', 'PI', 'RJ', 'RN', 'RS', 'RO', 'RR', 'SC', 'SP', 'SE', 'TO' ) NOT NULL, 
	cidade VARCHAR(255) NOT NULL, 
	bairro VARCHAR(255) NOT NULL, 
	rua VARCHAR(255) NOT NULL, 
	cep VARCHAR(20) NOT NULL, 
	numero INT, 
	complemento VARCHAR(255), 
	username VARCHAR(255) UNIQUE NOT NULL, 
	senha VARCHAR(255) NOT NULL, 
	tipo_usuario ENUM('Administrador', 'Municipe', 'OrgaoPublico') 
);

CREATE TABLE Agendamento ( 
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL, 
	data_agendamento DATE NOT NULL, 
	horario TIME NOT NULL, 
	pontuacao_total INT DEFAULT 0, 
	usuario_id INT, 
	FOREIGN KEY (usuario_id) REFERENCES Usuario(id) 
);

CREATE TABLE Noticia ( 
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL, 
    imagem VARCHAR(255) NOT NULL, 
    data_publicacao DATE NOT NULL, 
    titulo VARCHAR(255) NOT NULL, 
    resumo TEXT, conteudo TEXT, 
    usuario_id INT, 
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id) 
);

CREATE TABLE Produto ( 
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL, 
    nome VARCHAR(255) NOT NULL, 
    descricao TEXT, 
    pontuacao_unitaria INT NOT NULL, 
    usuario_id INT, 
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id) 
);

CREATE TABLE ItemColeta ( 
	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL, 
    agendamento_id INT, 
    produto_id INT, 
    quantidade INT NOT NULL, 
    estado_conservacao ENUM('Novo', 'Usado', 'Descarte') CHECK (estado_conservacao IN ('Novo', 'Usado', 'Descarte')), 
    pontuacao_total INT, 
    FOREIGN KEY (agendamento_id) REFERENCES Agendamento(id), FOREIGN KEY (produto_id) REFERENCES Produto(id) 
);
