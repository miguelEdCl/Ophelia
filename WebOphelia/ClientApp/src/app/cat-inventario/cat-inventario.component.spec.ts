import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CatInventarioComponent } from './cat-inventario.component';

describe('CatInventarioComponent', () => {
  let component: CatInventarioComponent;
  let fixture: ComponentFixture<CatInventarioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CatInventarioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CatInventarioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
