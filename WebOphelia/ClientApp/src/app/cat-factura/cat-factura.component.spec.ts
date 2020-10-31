import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CatFacturaComponent } from './cat-factura.component';

describe('CatFacturaComponent', () => {
  let component: CatFacturaComponent;
  let fixture: ComponentFixture<CatFacturaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CatFacturaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CatFacturaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
