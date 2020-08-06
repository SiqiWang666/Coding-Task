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
  places?: string;
}
