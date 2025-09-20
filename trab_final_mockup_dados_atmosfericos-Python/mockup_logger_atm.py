import psycopg2
from psycopg2 import sql
import random
import time
from datetime import datetime

# Configurações do banco
DB_CONFIG = {
    "dbname": "trab_final-Gestao_Estufas",
    "user": "postgres",
    "password": "210800",
    "host": "localhost",
    "port": 5432
}

def inserir_log(estufa_id, temperatura, umidade_ar):
    try:
        conn = psycopg2.connect(**DB_CONFIG)
        cur = conn.cursor()

        insert_query = sql.SQL("""
            INSERT INTO tb_logs_atmosfericos (estufa_id, data_hora, temperatura, umidade_ar)
            VALUES (%s, %s, %s, %s)
        """)

        cur.execute(insert_query, (estufa_id, datetime.now(), temperatura, umidade_ar))

        conn.commit()
        cur.close()
        conn.close()

        print(f"✅ Inserido: Estufa {estufa_id}, Temp={temperatura:.2f}°C, Umidade={umidade_ar:.2f}%")

    except Exception as e:
        print("❌ Erro ao inserir dados:", e)

if __name__ == "__main__":
    estufas = [1, 2, 3]  # IDs das estufas existentes no banco

    while True:
        estufa_id = random.choice(estufas)  # escolhe uma estufa aleatória
        temperatura = random.uniform(20.0, 35.0)  # temperatura entre 20°C e 35°C
        umidade_ar = random.uniform(50.0, 90.0)   # umidade entre 50% e 90%

        inserir_log(estufa_id, temperatura, umidade_ar)

        time.sleep(10)  # espera 10 segundos antes do próximo insert