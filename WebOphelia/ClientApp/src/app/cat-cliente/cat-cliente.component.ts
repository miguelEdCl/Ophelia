import { Component, OnInit } from '@angular/core';
import { CatClienteService } from '../services/CatCliente/cat-cliente.service';
@Component({
  selector: 'app-cat-cliente',
  templateUrl: './cat-cliente.component.html',
  styleUrls: ['./cat-cliente.component.css']
})
export class CatClienteComponent implements OnInit {
  Clientes: any;
  constructor(public CatClienteService: CatClienteService) { }
  ngOnInit() {
    this.CatClienteService.getUsers1().subscribe(data => {
      this.Clientes = data;
    });
    this.CatClienteService.getUsers();
  }
}
