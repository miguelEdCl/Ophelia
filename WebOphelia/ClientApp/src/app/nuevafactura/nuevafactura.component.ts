import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nuevafactura',
  templateUrl: './nuevafactura.component.html',
  styleUrls: ['./nuevafactura.component.css']
})
export class NuevafacturaComponent implements OnInit {
  FormData: FormGroup;
  constructor(private http: HttpClient, private builder: FormBuilder, private router: Router) {
    this.FormData = this.builder.group({
      IdFactura: new FormControl(''),
      IdProducto: new FormControl('', [Validators.required]),
      IdCliente: new FormControl('', [Validators.required]),
      Cantidad: new FormControl('', [Validators.required]),
      TotalCompra: new FormControl('', [Validators.required]),
      FechaCompra: new FormControl('', [Validators.required])
    });
  }
  ngOnInit(): void {
  }
    onSubmit(FormData) {
    this.http.post('http://localhost:44303/api/Factura', FormData).subscribe(
      (response) => console.log(response),
      (error) => console.log(error)
      )
      this.router.navigate(['/CatalogoFactura']);
  }
}
