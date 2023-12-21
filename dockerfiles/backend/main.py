from fastapi import Depends
from fastapi import FastAPI, Query

app = FastAPI(title="FastAPI")

@app.get("/")
def read_root():
    return {"hello": "world"}


