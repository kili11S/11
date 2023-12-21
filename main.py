app.py

from flask import Flask, render_template
import psycopg2

app = Flask(name)

# Конфигурация базы данных
db_config = {
    'dbname': 'storagedb',
    'user': 'your_username',
    'password': 'your_password',
    'host': 'your_host',
    'port': 'your_port'
}

# Подключение к базе данных
conn = psycopg2.connect(**db_config)
cursor = conn.cursor()

# Роут для отображения главной страницы
@app.route('/')
def index():
    # Выполнение SQL-запроса для получения данных из таблицы material
    cursor.execute('SELECT * FROM material')
    material_data = cursor.fetchall()

    # Выполнение SQL-запроса для получения данных из таблицы storages
    cursor.execute('SELECT * FROM storages')
    storages_data = cursor.fetchall()

    # Выполнение SQL-запроса для получения данных из таблицы suppliers
    cursor.execute('SELECT * FROM suppliers')
    suppliers_data = cursor.fetchall()

    return render_template('index.html', material=material_data, storages=storages_data, suppliers=suppliers_data)

if name == 'main':
    app.run(debug=True)