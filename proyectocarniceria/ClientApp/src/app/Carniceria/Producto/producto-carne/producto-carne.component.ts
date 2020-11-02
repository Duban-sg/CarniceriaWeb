import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-producto-carne',
  templateUrl: './producto-carne.component.html',
  styleUrls: ['./producto-carne.component.css']
})
export class ProductoCarneComponent implements OnInit {

  productos:[
    {"NombreProducto":"John", "Imagen":"Doe","Precio":"0000000","descripcion":"0000000"},

];
  constructor() { }

  ngOnInit(): void {
  }

}
