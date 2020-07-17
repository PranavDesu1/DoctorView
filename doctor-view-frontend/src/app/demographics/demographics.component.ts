import { Component, OnInit, Input } from '@angular/core';
import { Patient } from '../Models/Patient'

@Component({
  selector: 'app-demographics',
  templateUrl: './demographics.component.html',
  styleUrls: ['./demographics.component.css']
})
export class DemographicsComponent implements OnInit {
  @Input() patient: Patient;

  constructor() { }

  ngOnInit(): void {
  }

}
