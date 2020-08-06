import { Component, OnInit } from '@angular/core';
import { CabService } from 'src/app/core/services/cab.service';
import { Cab } from '../shared/models/cab';

@Component({
  selector: 'app-cab-list',
  templateUrl: './cab-list.component.html',
  styleUrls: ['./cab-list.component.css'],
})
export class CabListComponent implements OnInit {
  cabs: Cab[];
  constructor(private cabService: CabService) {}

  ngOnInit(): void {
    this.cabService.getAllCabs().subscribe((cs) => {
      this.cabs = cs;
      // console.log(this.cabs);
    });
  }
}
