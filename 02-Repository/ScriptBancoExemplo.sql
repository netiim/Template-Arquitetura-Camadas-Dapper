use sys;
CREATE TABLE IF NOT EXISTS Produto (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    idade INT NOT NULL,
    categoriaID INT NOT NULL
);

CREATE TABLE IF NOT EXISTS Categoria (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL
);
ALTER TABLE Produto
ADD COLUMN DataCriacao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
ADD COLUMN DataAlteracao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP;

INSERT INTO Categoria (Nome) VALUES ('Eletrônicos');
INSERT INTO Categoria (Nome) VALUES ('Roupas');
INSERT INTO Categoria (Nome) VALUES ('Alimentos');
INSERT INTO Categoria (Nome) VALUES ('Móveis');
INSERT INTO Categoria (Nome) VALUES ('Livros');

INSERT INTO Produto (Nome, Idade, CategoriaID) VALUES ('Smartphone', 10, 1);
INSERT INTO Produto (Nome, Idade, CategoriaID) VALUES ('TV 4K', 2999, 1);
INSERT INTO Produto (Nome, Idade, CategoriaID) VALUES ('Camiseta', 49, 2);
INSERT INTO Produto (Nome, Idade, CategoriaID) VALUES ('Calça Jeans', 89, 2);
INSERT INTO Produto (Nome, Idade, CategoriaID) VALUES ('Pizza', 29, 3);
INSERT INTO Produto (Nome, Idade, CategoriaID) VALUES ('Mesa de Jantar', 499, 4);
INSERT INTO Produto (Nome, Idade, CategoriaID) VALUES ('Livro de Ficção', 39, 5);
INSERT INTO Produto (Nome, Idade, CategoriaID) VALUES ('Cadeira de Escritório', 299, 4);
select *
from Exemplo;