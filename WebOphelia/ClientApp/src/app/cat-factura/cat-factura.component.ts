import { Component, OnInit } from '@angular/core';
import { CatFacturaService } from '../services/CatFactura/cat-factura.service';
@Component({
  selector: 'app-cat-factura',
  templateUrl: './cat-factura.component.html',
  styleUrls: ['./cat-factura.component.css']
})
export class CatFacturaComponent implements OnInit {

  Facturas: any;
  constructor(public CatFacturaService: CatFacturaService) { }
  ngOnInit() {
    this.CatFacturaService.getBill1().subscribe(data => {
      this.Facturas = data;
    });
    this.CatFacturaService.getBill();
  }

}
