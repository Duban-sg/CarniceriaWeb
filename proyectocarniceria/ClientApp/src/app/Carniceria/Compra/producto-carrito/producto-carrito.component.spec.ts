import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductoCarritoComponent } from './producto-carrito.component';

describe('ProductoCarritoComponent', () => {
  let component: ProductoCarritoComponent;
  let fixture: ComponentFixture<ProductoCarritoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductoCarritoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductoCarritoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
