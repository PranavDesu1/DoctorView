import { Component } from '@angular/core';
import { Patient } from '../app/Models/Patient'
import { PatientheaderComponent } from './patientheader/patientheader.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'doctor-view-poc';

  selectedPatient: Patient;

  patientChangedHandler(patient: Patient){
    this.selectedPatient = patient;
  }
}
