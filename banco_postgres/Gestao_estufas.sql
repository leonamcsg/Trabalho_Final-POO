-- Tabela principal: Estufas --------------------------------------------
CREATE TABLE tb_estufas (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    localizacao VARCHAR(150),
    tamanho_m2 NUMERIC,
	cultura VARCHAR(150)
);

-- Eventos de Irrigação ------------------------------------------------
CREATE TABLE tb_eventos_irrigacao (
    id SERIAL PRIMARY KEY,
    estufa_id INT NOT NULL,
    data_hora TIMESTAMP NOT NULL DEFAULT NOW(),
    duracao_segundos INT NOT NULL,
    FOREIGN KEY (estufa_id) REFERENCES tb_estufas(id) ON DELETE CASCADE
);

-- Logs de Dados Atmosféricos -------------------------------------------------
CREATE TABLE tb_logs_atmosfericos (
    id SERIAL PRIMARY KEY,
    estufa_id INT NOT NULL,
    data_hora TIMESTAMP NOT NULL DEFAULT NOW(),
    temperatura NUMERIC(5,2),
    umidade_ar NUMERIC(5,2),
    FOREIGN KEY (estufa_id) REFERENCES tb_estufas(id) ON DELETE CASCADE
);

-- Inserindo estufas
INSERT INTO tb_estufas (nome, localizacao, tamanho_m2, cultura)
VALUES 
('Estufa 1', 'Bloco A - Lado Norte', 120.5, 'Alface'),
('Estufa 2', 'Bloco B - Fundos', 200.0, 'Rúcula'),
('Estufa 3', 'Bloco c - Fundos', 300.0, 'Tomate');

-- Inserindo eventos de irrigação
INSERT INTO tb_eventos_irrigacao (estufa_id, data_hora, duracao_segundos)
VALUES 
(1, '2025-07-18 07:00:00', 10000),
(2, '2025-09-18 18:00:00', 450),
(3, '2025-09-18 07:30:00', 200);

-- Inserindo logs atmosféricos
INSERT INTO tb_logs_atmosfericos (estufa_id, data_hora, temperatura, umidade_ar)
VALUES 
(1, '2025-09-18 08:00:00', 26.5, 70.2),
(2, '2025-09-18 12:00:00', 29.1, 65.0),
(3, '2025-09-18 07:30:00', 25.0, 72.5);

----- COMANDOS DE CONTROLE ---------------

--SELECT * FROM tb_eventos_irrigacao;
--DELETE FROM tb_eventos_irrigacao;
--DROP TABLE tb_eventos_irrigacao;


--SELECT * FROM tb_logs_atmosfericos;
--DELETE FROM tb_logs_atmosfericos;
--DROP TABLE tb_logs_atmosfericos;

--SELECT * FROM tb_estufas;
--DELETE FROM tb_estufas;
--DROP TABLE tb_estufas;


