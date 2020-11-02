import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductoCerdoComponent } from './producto-cerdo.component';

describe('ProductoCerdoComponent', () => {
  let component: ProductoCerdoComponent;
  let fixture: ComponentFixture<ProductoCerdoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductoCerdoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductoCerdoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
