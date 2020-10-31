import { Component, OnInit } from '@angular/core';
import { CatInventarioService } from '../services/CatInventario/cat-inventario.service';

@Component({
  selector: 'app-cat-inventario',
  templateUrl: './cat-inventario.component.html',
  styleUrls: ['./cat-inventario.component.css']
})
export class CatInventarioComponent implements OnInit {

  Inventarios: any;
  constructor(public CatInventarioService: CatInventarioService) { }
  ngOnInit() {
    this.CatInventarioService.getStok1().subscribe(data => {
      this.Inventarios = data;
    });
    this.CatInventarioService.getStok();
  }
}
