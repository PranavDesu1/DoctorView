import { Component, OnInit, Input } from '@angular/core';
import { Patient } from '../Models/Patient'

@Component({
  selector: 'app-patientheader',
  templateUrl: './patientheader.component.html',
  styleUrls: ['./patientheader.component.css']
})
export class PatientheaderComponent implements OnInit {
  @Input() patient: Patient;

  constructor() { }

  ngOnInit(): void {
  }


}
