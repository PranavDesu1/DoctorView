import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormsModule } from '@angular/forms'

@Component({
  selector: 'app-search-patient',
  templateUrl: './search-patient.component.html',
  styleUrls: ['./search-patient.component.css']
})
export class SearchPatientComponent implements OnInit {
  @Output() patientList = new EventEmitter<String>();

  constructor() { }

  ngOnInit(): void {
  }

  onSearchType(value: string) {
    
  }

}
