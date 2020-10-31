import { TestBed } from '@angular/core/testing';

import { CatProductoService } from './cat-producto.service';

describe('CatProductoService', () => {
  let service: CatProductoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CatProductoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
