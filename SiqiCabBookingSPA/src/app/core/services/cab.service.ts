import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';
import { Cab } from 'src/app/shared/models/cab';

@Injectable({
  providedIn: 'root',
})
export class CabService {
  constructor(private apiService: ApiService) {}

  getAllCabs(): Observable<Cab[]> {
    return this.apiService.getAll('cab');
  }
}
