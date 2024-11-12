# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="04-Projeto de Interface.md"> Projeto de Interface</a></span>

A seguir, estão descritos os componentes e o ambiente de hospedagem da aplicação ReciclaMais. Este projeto busca oferecer uma plataforma de conexão para descarte sustentável de resíduos eletrônicos, integrando cidadãos e serviços de coleta.

![Arquitetura da Solução](img/arch-back.JPG)

## Diagrama de Classes

<figure>
  <img src="img/UMLclass2.png" alt="Diagrama de Classes - Versão 2">
  <figcaption style="text-align: center;">Diagrama de Classes - Versão 1(Etapa 2)</figcaption>
</figure>

Este diagrama de classes representa o sistema de agendamentos e coleta de produtos eletrônicos, voltado para diferentes tipos de usuários, incluindo administradores, municípes e órgãos públicos. O sistema permite o gerenciamento de produtos, agendamentos e notícias, com funcionalidades específicas para cada tipo de usuário.

<figure>
  <img src="img/DiagramaClassesReciclaMais.png" alt="Diagrama de Classes - Versão 2">
  <figcaption style="text-align: center;">Diagrama de Classes - Versão 2(Etapa 3)</figcaption>
</figure>

### Classes e Atributos
#### Administrador

A classe Administrador representa um usuário com privilégios de administração no sistema. O administrador possui atributos como NomeAdm e métodos para gerenciar notícias e produtos.
- Métodos:
1. CadastrarNoticia: Permite o cadastro de uma notícia com imagem, título, resumo, conteúdo, e data de publicação.
2. CadastrarProduto: Permite o cadastro de novos produtos com informações como nome, descrição e pontuação unitária.
3. ExcluirNoticia: Permite a exclusão de uma notícia específica.

#### Noticia

A classe Noticia representa as notícias cadastradas no sistema. Ela contém atributos como Id, Imagem, DataPublicacao, Titulo, Resumo, e Conteudo. As notícias podem ser gerenciadas pelo administrador e exibidas aos usuários do sistema.

#### Produto

A classe Produto define os produtos disponíveis para coleta no sistema. Os atributos incluem Id, Nome, Descricao e PontuacaoUnitaria, que indica a pontuação atribuída por unidade do produto. Os produtos cadastrados são utilizados nos agendamentos e compõem os itens de coleta.

#### ItemColeta

A classe ItemColeta representa um item específico que será coletado durante um agendamento. Cada ItemColeta está associado a um Produto e inclui atributos como Quantidade e EstadoConservacao.
O atributo EstadoConservacao é do tipo EstadoConservacao, um enumerado que indica o estado de conservação do item (Novo, Usado, ou Descarte).
- Método:
1. CalcularPontuacao: Calcula a pontuação do item multiplicando a pontuação unitária do produto pela quantidade especificada.


#### Agendamento

A classe Agendamento representa um agendamento de coleta de produtos. Ela contém atributos como Id, DataAgendamento, Horario, PontuacaoTotal, e uma lista de ItemColeta.
- Método:
1. CalcularPontuacaoTotal: Calcula a pontuação total do agendamento somando a pontuação de cada item de coleta.

#### Usuario

A classe Usuario é uma classe base para diferentes tipos de usuários no sistema. Ela inclui atributos como Id, Nome, Estado, Cidade, Bairro, Rua, Cep, Numero, Complemento, Username, e Password.
- Métodos:
1. VerificarLogin: Verifica as credenciais de login do usuário.
2. Cadastro: Permite o cadastro de um novo usuário.
3. Login: Realiza o login do usuário no sistema.
4. AtualizarPerfil: Permite que o usuário atualize seu perfil.

#### Municipe

A classe Municipe é uma especialização de Usuario e representa um usuário que pode fazer agendamentos de coleta. Ela contém atributos específicos como Cpf, Sobrenome, DataNascimento, e Pontuacao.
- Métodos:
1. CriarAgendamento: Permite que o município crie um novo agendamento de coleta.
2. ListarAgendamentos: Retorna uma lista de agendamentos feitos pelo município.

#### OrgaoPublico

A classe OrgaoPublico é outra especialização de Usuario, representando um órgão público que pode consultar agendamentos de coleta.
- Atributo:
Nome: Nome do órgão público.
- Método:
1. ConsultarAgendamentos: Permite que o órgão público consulte todos os agendamentos do sistema.

### Enumerações
#### TipoUsuario

Enumeração que define os tipos de usuários que podem acessar o sistema: Administrador, Municipio, e OrgaoPublico.

#### EstadosBrasil

Enumeração que define os estados do Brasil, utilizados no atributo Estado da classe Usuario.

#### EstadoConservacao

Enumeração que define o estado de conservação de um item de coleta: Novo, Usado, e Descarte.

### Relacionamentos entre Classes
- Herança: A classe Usuario é a classe base para Municipe e OrgaoPublico, representando a relação "é-um" (ou especialização) entre usuários do sistema.

- Agendamento e ItemColeta: A classe Agendamento possui uma associação de 1 para * com ItemColeta, indicando que um agendamento pode conter vários itens de coleta.

- ItemColeta e Produto: Cada ItemColeta está associado a um Produto, permitindo acesso direto às informações de pontuação do produto.

- Administrador, Noticia, e Produto: A classe Administrador tem métodos para gerenciar Noticia e Produto, indicando que o administrador é responsável por manter esses registros no sistema.

## Modelo ER

<figure>
  <img src="img/modeloer.png" alt="Diagrama de Classes - Versão 2">
  <figcaption style="text-align: center;">MER - Versão 1(Etapa 2)</figcaption>
</figure>

<figure>
  <img src="img/MER ReciclaMais V2-1.png" alt="Diagrama de Classes - Versão 2">
  <figcaption style="text-align: center;">MER - Versão 2.1(Etapa 3)</figcaption>
</figure>

Usuario é a entidade principal que armazena as informações gerais de cada usuário, incluindo atributos como Nome, Cpf, DataNascimento, Endereco, e TipoUsuario, que define se o usuário é um Administrador, OrgaoPublico, ou Municipe.

Produto representa os produtos que podem ser coletados, com cada produto possuindo uma PontuacaoUnitaria.

Agendamento é a entidade que permite que um Municipe realize um agendamento de coleta.

Noticia representa as notícias que podem ser cadastradas no sistema, uma tarefa atribuída aos Administradores.

ItemColeta representa os itens de coleta específicos de cada agendamento, associando um produto a uma quantidade e ao estado de conservação.


## Esquema Relacional

<figure>
  <img src="img/esquemarelacional.png" alt="Diagrama de Classes - Versão 2">
  <figcaption style="text-align: center;">Modelo Relacional - Versão 1(Etapa 2)</figcaption>
</figure>

<figure>
  <img src="img/ModeloRelacional-Versao 2.png" alt="Diagrama de Classes - Versão 2">
  <figcaption style="text-align: center;">Modelo Relacional - Versão 2(Etapa 3)</figcaption>
</figure>


## Modelo Físico (DDL)

```
CREATE DATABASE RMDatabase; 
USE RMDatabase;

CREATE TABLE Usuario ( id INT PRIMARY KEY, 
    nome VARCHAR(255) NOT NULL, sobrenome VARCHAR(255), data_nascimento DATE,pontuacao INT, cpf VARCHAR(20), estado ENUM( 'AC', 'AL', 'AP', 'AM', 'BA', 'CE', 'DF', 'ES', 'GO', 'MA', 'MT', 'MS', 'MG', 'PA', 'PB', 'PR', 'PE', 'PI', 'RJ', 'RN', 'RS', 'RO', 'RR', 'SC', 'SP', 'SE', 'TO' ) NOT NULL, 
    cidade VARCHAR(255) NOT NULL, 
    bairro VARCHAR(255) NOT NULL, 
    rua VARCHAR(255) NOT NULL, 
    cep VARCHAR(20) NOT NULL, 
    numero INT, 
    complemento VARCHAR(255), 
    username VARCHAR(255) UNIQUE NOT NULL, senha VARCHAR(255) NOT NULL, 
    tipo_usuario ENUM('Administrador', 'Municipe', 'OrgaoPublico') );

CREATE TABLE Agendamento ( 
    id INT PRIMARY KEY,
    data_agendamento DATE NOT NULL, 
    horario TIME NOT NULL, 
    pontuacao_total INT DEFAULT 0, 
    usuario_id INT, 
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id) );

CREATE TABLE Noticia ( 
    id INT PRIMARY KEY, 
    imagem VARCHAR(255) NOT NULL, data_publicacao DATE NOT NULL, 
    titulo VARCHAR(255) NOT NULL, 
    resumo TEXT, conteudo TEXT, 
    usuario_id INT, 
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id) );

CREATE TABLE Produto ( 
    id INT PRIMARY KEY, 
    nome VARCHAR(255) NOT NULL, 
    descricao TEXT, 
    pontuacao_unitaria INT NOT NULL, 
    usuario_id INT, 
    FOREIGN KEY (usuario_id) REFERENCES Usuario(id) );

CREATE TABLE ItemColeta ( 
    id INT PRIMARY KEY, 
    agendamento_id INT, 
    produto_id INT, 
    quantidade INT NOT NULL, 
    estado_conservacao ENUM('Novo', 'Usado', 'Descarte') CHECK (estado_conservacao IN ('Novo', 'Usado', 'Descarte')), pontuacao_total INT, 
    FOREIGN KEY (agendamento_id) REFERENCES Agendamento(id), FOREIGN KEY (produto_id) REFERENCES Produto(id) );
```

## Instruções SQL de Manipulação do BD (DML)

#### Inserir Dados
```
-- Inserindo dados na tabela Usuario 
INSERT INTO Usuario (nome, sobrenome,
    data_nascimento, pontuacao, cpf, estado, cidade, bairro, rua, cep, numero, complemento, username, senha, tipo_usuario
VALUES 
    ('João', 'Silva', '1990-05-20', 100, '123.456.789-00', 'SP', 'São Paulo', 'Centro', 'Rua A', '01000-000', 123, 'Apto 45', 'joaosilva', 'senha123', 'Municipe'), 
    ('Maria', 'Oliveira', '1985-08-15', 200, '987.654.321-00', 'RJ', 'Rio de Janeiro', 'Copacabana', 'Avenida B', '22000-000', 456, 'Ap 101', 'mariaoliveira', 'senha456', 'Administrador'); 

-- Inserindo dados na tabela Agendamento 
INSERT INTO Agendamento (data_agendamento, horario, pontuacao_total, usuario_id) 
VALUES 
    ('2024-11-15', '10:00:00', 50, 1),
    ('2024-11-16', '14:00:00', 40, 2); 
    
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
    (2, 2, 3, 'Usado', 60
```

#### Atualizar Dados
```
-- Atualizando dados na tabela Usuario 
UPDATE Usuario 
SET nome = 'João Pedro', pontuacao = 150 WHERE id = 1; 
UPDATE Usuario 
SET cidade = 'Niterói', pontuacao = 220 WHERE id = 2; 

-- Atualizando dados na tabela Agendamento UPDATE Agendamento 
SET pontuacao_total = 70 
WHERE id = 1; 
UPDATE Agendamento 
SET horario = '15:00:00' 
WHERE id = 2; 

-- Atualizando dados na tabela Noticia 
UPDATE Noticia 
SET titulo = 'Título Atualizado da Notícia 1' WHERE id = 1; 
UPDATE Noticia 
SET resumo = 'Resumo atualizado da notícia 2' WHERE id = 2; 

-- Atualizando dados na tabela Produto 
UPDATE Produto 
SET pontuacao_unitaria = 25 
WHERE id = 2; 
UPDATE Produto 
SET descricao = 'Nova descrição do Produto C' WHERE id = 3; 

-- Atualizando dados na tabela ItemColeta UPDATE ItemColeta 
SET estado_conservacao = 'Usado', pontuacao_total = 55 
WHERE id = 1; 
UPDATE ItemColeta 
SET quantidade = 4, pontuacao_total = 80 
WHERE id = 2; 
```

#### Excluir Dados
```
-- Deletando dados na tabela Usuario
DELETE FROM Usuario
WHERE id = 1;
DELETE FROM Usuario
WHERE id = 2;

-- Deletando dados na tabela Agendamento
DELETE FROM Agendamento
WHERE id = 1;
DELETE FROM Agendamento
WHERE id = 2;

-- Deletando dados na tabela Noticia
DELETE FROM Noticia
WHERE id = 1;
DELETE FROM Noticia
WHERE id = 2;

-- Deletando dados na tabela Produto
DELETE FROM Produto
WHERE id = 1;
DELETE FROM Produto
WHERE id = 2;

-- Deletando dados na tabela ItemColeta
DELETE FROM ItemColeta
WHERE id = 1;
DELETE FROM ItemColeta
WHERE id = 2;

```
## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
