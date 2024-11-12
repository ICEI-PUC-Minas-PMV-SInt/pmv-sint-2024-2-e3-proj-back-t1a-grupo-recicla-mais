-- Inserindo dados na tabela Usuario
INSERT INTO Usuario (nome, sobrenome, data_nascimento, pontuacao, cpf, estado, cidade, bairro, rua, cep, numero, complemento, username, senha, tipo_usuario) 
VALUES 
('João', 'Silva', '1990-05-20', 100, '123.456.789-00', 'SP', 'São Paulo', 'Centro', 'Rua A', '01000-000', 123, 'Apto 45', 'joaosilva', 'senha123', 'Municipe'),
('Maria', 'Oliveira', '1985-08-15', 200, '987.654.321-00', 'RJ', 'Rio de Janeiro', 'Copacabana', 'Avenida B', '22000-000', 456, 'Ap 101', 'mariaoliveira', 'senha456', 'Administrador');

-- Inserindo dados na tabela Agendamento
INSERT INTO Agendamento (data_agendamento, horario, pontuacao_total, usuario_id) 
VALUES 
('2024-11-15', '10:00:00', 50, 3),
('2024-11-16', '14:00:00', 40, 4);

-- Inserindo dados na tabela Noticia
INSERT INTO Noticia (imagem, data_publicacao, titulo, resumo, conteudo, usuario_id) 
VALUES 
('imagem1.jpg', '2024-11-10', 'Título da Notícia 1', 'Resumo da notícia 1', 'Conteúdo detalhado da notícia 1', 1),
('imagem2.jpg', '2024-11-11', 'Título da Notícia 2', 'Resumo da notícia 2', 'Conteúdo detalhado da notícia 2', 2);

-- Inserindo dados na tabela Produto
INSERT INTO Produto (nome, descricao, pontuacao_unitaria, usuario_id) 
VALUES 
('Produto A', 'Descrição do Produto A', 10, 1),
('Produto B', 'Descrição do Produto B', 20, 2);

-- Inserindo dados na tabela ItemColeta
INSERT INTO ItemColeta (agendamento_id, produto_id, quantidade, estado_conservacao, pontuacao_total) 
VALUES 
(1, 1, 5, 'Novo', 50),
(2, 2, 3, 'Usado', 60);


-- Atualizando dados na tabela Usuario
UPDATE Usuario
SET nome = 'João Pedro', pontuacao = 150
WHERE id = 1;

UPDATE Usuario
SET cidade = 'Niterói', pontuacao = 220
WHERE id = 2;

-- Atualizando dados na tabela Agendamento
UPDATE Agendamento
SET pontuacao_total = 70
WHERE id = 1;

UPDATE Agendamento
SET horario = '15:00:00'
WHERE id = 2;

-- Atualizando dados na tabela Noticia
UPDATE Noticia
SET titulo = 'Título Atualizado da Notícia 1'
WHERE id = 1;

UPDATE Noticia
SET resumo = 'Resumo atualizado da notícia 2'
WHERE id = 2;

-- Atualizando dados na tabela Produto
UPDATE Produto
SET pontuacao_unitaria = 25
WHERE id = 2;

UPDATE Produto
SET descricao = 'Nova descrição do Produto C'
WHERE id = 3;

-- Atualizando dados na tabela ItemColeta
UPDATE ItemColeta
SET estado_conservacao = 'Usado', pontuacao_total = 55
WHERE id = 1;

UPDATE ItemColeta
SET quantidade = 4, pontuacao_total = 80
WHERE id = 2;



-- Deletando dados na tabela ItemColeta
DELETE FROM ItemColeta
WHERE id = 1;

DELETE FROM ItemColeta
WHERE id = 2;

-- Deletando dados na tabela Produto
DELETE FROM Produto
WHERE id = 1;

DELETE FROM Produto
WHERE id = 2;

-- Deletando dados na tabela Noticia
DELETE FROM Noticia
WHERE id = 1;

DELETE FROM Noticia
WHERE id = 2;

-- Deletando dados na tabela Agendamento
DELETE FROM Agendamento
WHERE id = 1;

DELETE FROM Agendamento
WHERE id = 2;

-- Deletando dados na tabela Usuario
DELETE FROM Usuario
WHERE id = 1;

DELETE FROM Usuario
WHERE id = 2;













