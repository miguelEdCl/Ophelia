import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class CatProductoService {


  constructor(private http: HttpClient) { }
  getProducts1(): Observable<any> {
    return this.http.get("https://localhost:44303/api/CatProducto");
  }
  getProducts() {
    this.http.get("https://localhost:44303/api/CatProducto").subscribe(data => {
      console.log(data);
    });
  }
}
