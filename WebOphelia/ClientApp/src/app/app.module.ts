import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';


import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CatClienteComponent } from './cat-cliente/cat-cliente.component';
import { CatProductoComponent } from './cat-producto/cat-producto.component';
import { CatInventarioComponent } from './cat-inventario/cat-inventario.component';
import { CatFacturaComponent } from './cat-factura/cat-factura.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CatClienteComponent,
    CatProductoComponent,
    CatInventarioComponent,
    CatFacturaComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'CatalogoCliente', component: CatClienteComponent },
      { path: 'CatalogoProducto', component: CatProductoComponent },
      { path: 'CatalogoInventario', component: CatInventarioComponent },
      { path: 'CatalogoFactura', component: CatFacturaComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
