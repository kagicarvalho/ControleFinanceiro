import { TestBed } from '@angular/core/testing';

import { TiposService } from './tipos.service';

describe('TiposServiceService', () => {
  let service: TiposService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TiposService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
