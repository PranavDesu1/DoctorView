import { Component, OnInit, Input } from '@angular/core';
import { Patient } from '../Models/Patient'
import { DIAGNOSIS } from '../Mocks/MockDiagnosis'

@Component({
  selector: 'app-diagnosis',
  templateUrl: './diagnosis.component.html',
  styleUrls: ['./diagnosis.component.css']
})
export class DiagnosisComponent implements OnInit {
  
  @Input() patient: Patient;

  diagnosis = DIAGNOSIS;

  constructor() { }

  ngOnInit(): void {
  }

}
