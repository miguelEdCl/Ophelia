import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class CatInventarioService {

  constructor(private http: HttpClient) { }
  getStok1(): Observable<any> {
    return this.http.get("https://localhost:44303/api/CatInventario");
  }
  getStok() {
    this.http.get("https://localhost:44303/api/CatInventario").subscribe(data => {
      console.log(data);
    });
  }
}
