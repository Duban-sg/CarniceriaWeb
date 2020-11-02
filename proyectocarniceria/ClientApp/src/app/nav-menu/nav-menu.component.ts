import { Component } from '@angular/core';
import { CarritoComponent } from '../Carniceria/Compra/carrito/carrito.component';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  abrirCarrito(){
    var btnAbrir = document.getElementById("overlay");
    btnAbrir.classList.add("active");
  }

  cerrarCarrito(){
    var btnAbrir = document.getElementById("overlay");
    btnAbrir.classList.remove("active");
  }
}
