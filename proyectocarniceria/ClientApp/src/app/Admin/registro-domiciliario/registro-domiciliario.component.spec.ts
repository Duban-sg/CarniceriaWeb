import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistroDomiciliarioComponent } from './registro-domiciliario.component';

describe('RegistroDomiciliarioComponent', () => {
  let component: RegistroDomiciliarioComponent;
  let fixture: ComponentFixture<RegistroDomiciliarioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistroDomiciliarioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistroDomiciliarioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
