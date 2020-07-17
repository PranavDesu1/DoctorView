import { Component, OnInit } from '@angular/core';
import { Patient } from '../Models/Patient'
import { PATIENTS } from '../Mocks/MockPatients'
import { FormsModule } from '@angular/forms'

@Component({
  selector: 'app-patientlist',
  templateUrl: './patientlist.component.html',
  styleUrls: ['./patientlist.component.css']
})
export class PatientlistComponent implements OnInit {

  patients = PATIENTS;
  selectedPatient: Patient;

  constructor() { }

  ngOnInit(): void {
  }

  onSelect(patient: Patient){
    this.selectedPatient = patient;
  }
}
