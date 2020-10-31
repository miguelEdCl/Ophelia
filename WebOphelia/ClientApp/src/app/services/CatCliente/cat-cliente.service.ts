import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CatClienteService {

  constructor(private http: HttpClient) { }
  getUsers1(): Observable<any> {
    return this.http.get("https://localhost:44303/api/CatCliente");
  }
  getUsers() {
    this.http.get("https://localhost:44303/api/CatCliente").subscribe(data => {
      console.log(data);
    });
  }
}
