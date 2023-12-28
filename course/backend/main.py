from flask import Flask, render_template, url_for, redirect, request
import psycopg2

app = Flask(__name__)

def get_db_connection():
 conn = psycopg2.connect(host='postgres', database='storagedb', user='postgres', password='password')
 return conn

@app.route('/')
def index():
  conn = get_db_connection()
  cursor = conn.cursor()
  cursor.execute("select * from storagedbscheme.material")
  materials = cursor.fetchall()
  cursor.close
  cursor = conn.cursor()
  cursor.execute("select * from storagedbscheme.storages")
  storages = cursor.fetchall()
  cursor.close
  cursor = conn.cursor()
  cursor.execute("select * from storagedbscheme.suppliers")
  suppliers = cursor.fetchall()
  cursor.close
  cursor = conn.cursor()
  cursor.execute("select * from storagedbscheme.requestors")
  requestors = cursor.fetchall()
  cursor.close
  cursor = conn.cursor()
  cursor.execute("select * from stored_material_veiw")
  storage_view_logs = cursor.fetchall()
  cursor.close
  cursor = conn.cursor()
  cursor.execute("select * from request_logs_view")
  R_logs = cursor.fetchall()
  cursor.close
  cursor = conn.cursor()
  cursor.execute("select * from supply_logs_view")
  S_logs = cursor.fetchall()
  cursor.close
  return render_template('index.html', materials=materials, storages=storages, suppliers=suppliers, requestors=requestors, storage_view_logs=storage_view_logs, R_logs=R_logs, S_logs=S_logs)

@app.route("/create/", methods=["GET","POST"])
def create():
  if request.method == 'POST':
   conn=get_db_connection()
   cursor=conn.cursor()
   mat_name = request.form['name']
   mat_weight = request.form['mass']
   mat_size = request.form['size']
   cursor.execute('INSERT INTO storagedbscheme.material (name, mass, cubicmetres) VALUES (%s, %s, %s)',(mat_name, mat_weight, mat_size))
   conn.commit()
   cursor.close()
   conn.close()
   return redirect(url_for('index'))
  return render_template('create.html')

if __name__ == '__main__':
    app.run(host='0.0.0.0', debug=True)
