import { Placeholder } from '@angular/compiler/src/i18n/i18n_ast';

export interface Booking {
  id: number;
  email: string;
  bookingDate: Date;
  bookingTime?: Date;
  fromPlaceId: number;
  toPlaceId: number;
  pickupAddress?: string;
  landmark?: string;
  pickupDate?: Date;
  pickupTime?: Date;
  contactNo?: string;
  status?: string;

  startPlace: string;
  toPlace: string;
}
