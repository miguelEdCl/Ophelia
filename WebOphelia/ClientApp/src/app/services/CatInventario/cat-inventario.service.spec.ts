import { TestBed } from '@angular/core/testing';

import { CatInventarioService } from './cat-inventario.service';

describe('CatInventarioService', () => {
  let service: CatInventarioService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CatInventarioService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
