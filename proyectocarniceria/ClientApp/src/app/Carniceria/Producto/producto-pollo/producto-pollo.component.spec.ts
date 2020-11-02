import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductoPolloComponent } from './producto-pollo.component';

describe('ProductoPolloComponent', () => {
  let component: ProductoPolloComponent;
  let fixture: ComponentFixture<ProductoPolloComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductoPolloComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductoPolloComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
