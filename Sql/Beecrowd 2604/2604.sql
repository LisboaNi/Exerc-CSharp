CREATE TABLE products (
id numeric PRIMARY KEY,
name varchar(255),
amount numeric,
price numeric
);

-- Inserção de dados na tabela customers
INSERT INTO products (id, name, amount, price)
VALUES
(1, 'Two-door wardrobe', 100, 80),
(2, 'Dinig table', 1000, 560),
(3, 'Towel table', 10000, 5.50),
(4, 'Computer desk', 350, 100),
(5, 'Chair', 3000, 210.64),
(6, 'Single bed', 750, 99);

SELECT id, name
FROM products
WHERE price < 10 or price > 100;
