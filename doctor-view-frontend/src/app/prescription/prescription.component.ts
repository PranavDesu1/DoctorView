import { Component, OnInit, Input } from '@angular/core';
import { Patient } from '../Models/Patient'
import { PRESCRIPTION } from '../Mocks/MockPrescription'

@Component({
  selector: 'app-prescription',
  templateUrl: './prescription.component.html',
  styleUrls: ['./prescription.component.css']
})
export class PrescriptionComponent implements OnInit {
  @Input() patient: Patient;

  prescriptions = PRESCRIPTION;

  constructor() { }

  ngOnInit(): void {
  }

}
