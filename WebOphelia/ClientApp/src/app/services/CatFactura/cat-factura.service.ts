import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CatFacturaService {

  constructor(private http: HttpClient) { }
  getBill1(): Observable<any> {
    return this.http.get("https://localhost:44303/api/Factura");
  }
  getBill() {
    this.http.get("https://localhost:44303/api/Factura").subscribe(data => {
      console.log(data);
    });
  }
}
