import { Component, OnInit,PipeTransform } from '@angular/core';
import { DecimalPipe } from '@angular/common';
import { FormControl } from '@angular/forms';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';
import { Domiciliario } from 'src/app/Carniceria/models/domiciliario';
import { Documento } from 'src/app/Carniceria/models/documento';
import { DomiciliarioService } from 'src/app/services/domiciliario.service';


@Component({
  selector: 'app-registro-domiciliario',
  templateUrl: './registro-domiciliario.component.html',
  styleUrls: ['./registro-domiciliario.component.css'],
})
export class RegistroDomiciliarioComponent implements OnInit {

  submitted = false
  registerDomiciliaryForm:FormGroup;
  domiciliario:Domiciliario;
  documento:Documento;

  constructor(
    private domiciliarioService: DomiciliarioService,
    private formBuilder : FormBuilder )
  { 

  }

  /*identificacion:string;     
    nombre:string;
    apellido:string;
    correo:string;
    telefono:string; 
    documentos:Documento[]; 
  */

  ngOnInit(): void {

    this.domiciliario = new Domiciliario();
    this.domiciliario.identificacion = "";
    this.domiciliario.nombre = "";
    this.domiciliario.apellido = "";
    this.domiciliario.correo = "";
    this.domiciliario.telefono = "";
    this.registerDomiciliaryForm = this.formBuilder.group(
      {
        inputEmail : [this.domiciliario.correo,Validators.required],
        inputIdentificacion :  [this.domiciliario.identificacion, [Validators.required, Validators.min(7), Validators.max(10)]],
        inputNombre : [this.domiciliario.nombre,Validators.required],
        inputApellido : [this.domiciliario.apellido,Validators.required],
        inputTelefono : [this.domiciliario.telefono,[Validators.required,Validators.min(10)]]
      });
  }

  get f() { return this.registerDomiciliaryForm.controls; }

  //Manejo Registrar
  onSubmit() {
    this.submitted = true;
    // stop here if form is invalid
    if (this.registerDomiciliaryForm.invalid) {
        return;
    }
    this.add();
   }

    add(){
      this.domiciliarioService.post(this.domiciliario).subscribe(c => {
        if (c != null) {
          alert('Cliente registrado!');
          this.domiciliario = c;
        }
      });
   }

   onReset() {
    this.submitted = false;
    this.registerDomiciliaryForm.reset();
    }
  

}
