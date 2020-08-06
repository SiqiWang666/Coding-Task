import { Component, OnInit, Input } from '@angular/core';
import { Cab } from '../models/cab';

@Component({
  selector: 'app-cab-card',
  templateUrl: './cab-card.component.html',
  styleUrls: ['./cab-card.component.css'],
})
export class CabCardComponent implements OnInit {
  @Input() cab: Cab;
  constructor() {}

  ngOnInit(): void {}
}
