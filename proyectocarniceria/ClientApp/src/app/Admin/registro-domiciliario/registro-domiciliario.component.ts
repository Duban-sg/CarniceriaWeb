import { Component, OnInit,PipeTransform } from '@angular/core';
import { DecimalPipe } from '@angular/common';
import { FormControl } from '@angular/forms';

import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';





@Component({
  selector: 'app-registro-domiciliario',
  templateUrl: './registro-domiciliario.component.html',
  styleUrls: ['./registro-domiciliario.component.css'],
})
export class RegistroDomiciliarioComponent implements OnInit {

  

  constructor( ) { 

  }

  ngOnInit(): void {
  }

}
