import { Injectable } from '@angular/core';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root',
})
export class BookingService {
  constructor(private apiService: ApiService) {}
  getAllBookingsByCab(id: number) {
    return this.apiService.getAll(`cab/bookings/${id}`);
  }
}
