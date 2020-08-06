import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CabListComponent } from './cab/cab-list.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { CabCardComponent } from './shared/components/cab-card.component';
import { HeaderComponent } from './core/layout/header.component';
import { BookingComponent } from './booking/booking.component';

@NgModule({
  declarations: [AppComponent, CabListComponent, CabCardComponent, HeaderComponent, BookingComponent],
  imports: [BrowserModule, AppRoutingModule, NgbModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
