# 💻 Repositório de Exercícios e Projetos

Este repositório contém diversos exercícios e projetos de programação com foco em **C#**, **SQL** e **Node.js**. O objetivo é oferecer material prático para estudo de lógica, estruturas de controle, arrays, manipulação de dados e testes unitários.

---

## 📚 Seções

- [🔹 Exercícios em C#](#-exercícios-em-c)
- [🔸 Exercícios em SQL](#-exercícios-em-sql)
- [🧪 Testes Unitários com Node.js](#-testes-unitários-com-nodejs)

---

## 🔹 Exercícios em C#

### 1. Exercícios Básicos de C#

Este conjunto contém **20 exercícios introdutórios**, abordando:

- Operações matemáticas
- Controle de fluxo
- Entrada e saída de dados

**Conteúdo por categoria:**

1. **Condicionais** — Exercícios: 3, 5, 9, 12 até 17
2. **Operações matemáticas** — Exercícios: 1, 6, 10, 18
3. **Estrutura de repetição** — Exercícios: 19 e 20
4. **Operações básicas** — Exercícios: 2 e 7
5. **Repetições e condicionais** — Exercícios: 4, 8 e 11

### 2. Exercícios de Arrays e Laços

**10 exercícios práticos** com foco em vetores e laços, como:

- Soma de pares
- Média de ímpares
- Substituição de negativos
- Exibição invertida de valores

### 3. Exercícios de Arrays e Estruturas de Controle

**9 exercícios intermediários** com destaque para:

- Processamento de dados de múltiplos elementos
- Cálculo de notas e votos
- Simulação de pesquisa populacional

### Tecnologias e Recursos

- Linguagem: **C#**
- Entrada/Saída: `Console.ReadLine()`, `Console.WriteLine()`
- Estruturas condicionais: `if`, `else`, `switch`
- Laços: `for`, `while`, `foreach`
- Arrays e listas: `int[]`, `double[]`, `List<T>`
- Funções matemáticas: `Math.Pow()`, `Math.Max()`, `Math.Abs()`

---

## 🔸 Exercícios em SQL

Coleção de exercícios resolvidos da plataforma **Beecrowd**, utilizando comandos SQL em um contexto realista de banco de dados.

### Exercícios

1. **2604 - Menor que 10 ou Maior que 100**  
   Exibir produtos com preço < 10 ou > 100

2. **2603 - Customer Address**  
   Listar nomes e endereços de clientes de _Porto Alegre_

3. **2602 - Basic Select**  
   Exibir nomes de clientes cujo estado seja `'RS'`

### Tecnologias

- Linguagem: **SQL**
- Banco: **MySQL**
- Comandos: `SELECT`, `WHERE`, `CREATE`, `INSERT`

---

## 🧪 Testes Unitários com Node.js

Este projeto implementa **testes unitários em JavaScript** para uma calculadora simples.

### Funcionalidades

- Soma
- Subtração
- Divisão
- Multiplicação

### Tecnologias

- **Node.js**
- **Jest**

### Execução

```bash
# Clone esse repositório
# Acesse o diretório
cd DevOps
cd calculadora-teste

# Instale as dependências
npm install

# Execute os testes
npm test

# Exemplo
test("Testando soma", () => {
  const esperado = 25;
  const retorno = soma(15, 10);
  expect(retorno).toBe(esperado);
});

```
