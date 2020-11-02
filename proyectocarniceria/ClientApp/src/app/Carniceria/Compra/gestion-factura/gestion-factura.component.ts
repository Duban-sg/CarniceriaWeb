import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-gestion-factura',
  templateUrl: './gestion-factura.component.html',
  styleUrls: ['./gestion-factura.component.css']
})
export class GestionFacturaComponent implements OnInit {
  active = 1;
  constructor() { } 
  
  ngOnInit(): void {
  }

}
