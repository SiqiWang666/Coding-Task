import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CabListComponent } from './cab/cab-list.component';
import { BookingComponent } from './booking/booking.component';

const routes: Routes = [
  { path: '', component: CabListComponent },
  {
    path: 'cab/bookings/:id',
    component: BookingComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
