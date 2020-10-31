import { TestBed } from '@angular/core/testing';

import { CatFacturaService } from './cat-factura.service';

describe('CatFacturaService', () => {
  let service: CatFacturaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CatFacturaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
