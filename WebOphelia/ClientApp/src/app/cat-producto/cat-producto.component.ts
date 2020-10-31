import { Component, OnInit } from '@angular/core';
import { CatProductoService } from '../services/CatProducto/cat-producto.service';

@Component({
  selector: 'app-cat-producto',
  templateUrl: './cat-producto.component.html',
  styleUrls: ['./cat-producto.component.css']
})
export class CatProductoComponent implements OnInit {

  Productos: any;
  constructor(public CatProductoService: CatProductoService) { }
  ngOnInit() {
    this.CatProductoService.getProducts1().subscribe(data => {
      this.Productos = data;
    });
    this.CatProductoService.getProducts();
  }

}
