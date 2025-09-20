Projeto Final da Disciplina POO
# 🌱 Gerenciador de Estufas

Este projeto é um sistema de **gerenciamento de estufas** que utiliza **PostgreSQL** para armazenar informações de eventos (irrigação, exaustor, iluminação) e logs atmosféricos.  
Além disso, possui um script em **Python** que insere dados atmosféricos simulados automaticamente no banco de dados.

---

## 📋 Funcionalidades

- Cadastro de **estufas**
- Registro de:
  - Eventos de irrigação
  - Logs atmosféricos (temperatura e umidade do ar)
- Script em Python que:
  - Gera valores **aleatórios de sensores**
  - Insere novos registros no banco a cada **10 segundos**

---

## 🛠️ Tecnologias utilizadas

- [PostgreSQL](https://www.postgresql.org/)  
- [Visual Studio Community](https://visualstudio.microsoft.com/) com **Windows Forms**  
- [Npgsql](https://www.npgsql.org/) – driver .NET para PostgreSQL  
- [Python 3](https://www.python.org/) com [psycopg2](https://pypi.org/project/psycopg2-binary/)

---

## 🗄️ Estrutura do Banco de Dados

Exemplo simplificado das tabelas principais:

```sql
CREATE TABLE estufas (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    localizacao VARCHAR(150),
    tamanho_m2 NUMERIC,
    cultura VARCHAR(150)
);

CREATE TABLE tb_logs_atmosfericos (
    id SERIAL PRIMARY KEY,
    estufa_id INT NOT NULL,
    data_hora TIMESTAMP NOT NULL DEFAULT NOW(),
    temperatura NUMERIC(5,2),
    umidade_ar NUMERIC(5,2),
    FOREIGN KEY (estufa_id) REFERENCES estufas(id) ON DELETE CASCADE
);
