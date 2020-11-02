import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsuarioGestionPerfilComponent } from './usuario-gestion-perfil.component';

describe('UsuarioGestionPerfilComponent', () => {
  let component: UsuarioGestionPerfilComponent;
  let fixture: ComponentFixture<UsuarioGestionPerfilComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UsuarioGestionPerfilComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UsuarioGestionPerfilComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
