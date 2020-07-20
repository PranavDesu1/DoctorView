import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Patient } from '../Models/Patient'
import { PATIENTS } from '../Mocks/MockPatients'
import { FormsModule } from '@angular/forms'
import { HttpClientComponent } from '../http/http.component';
import { HttpClient } from '@angular/common/http';
import { SharedInternalData } from '../sharedData/sharedData';

@Component({
  selector: 'app-patientlist',
  templateUrl: './patientlist.component.html',
  styleUrls: ['./patientlist.component.css']
})
export class PatientlistComponent implements OnInit {
  //@Output() patientChanged: EventEmitter<Patient> = new EventEmitter();

  patients: Patient[];

  constructor(private _sharedService:SharedInternalData) { 
    
  }

  ngOnInit(): void {
    this._sharedService.updatePatientList.subscribe(patientInfo =>{
      this.patients = patientInfo;      
    });
  }

  ngOnDestroy() {
    this._sharedService.updatePatientList.unsubscribe();
  }

  onSelect(patient: Patient){
    this._sharedService.onPatientChange(patient);
  }
}
