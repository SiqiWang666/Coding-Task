import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Booking } from 'src/app/shared/models/booking';
import { BookingService } from 'src/app/core/services/booking.service';

@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css'],
})
export class BookingComponent implements OnInit {
  cabId: number;
  bookings: Booking[];

  constructor(
    private bookingService: BookingService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      this.cabId = +params.get('id');
      this.bookingService.getAllBookingsByCab(this.cabId).subscribe((bs) => {
        this.bookings = bs;
        console.log(this.bookings);
      });
    });
  }
}
