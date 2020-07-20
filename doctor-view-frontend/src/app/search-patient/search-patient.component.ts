import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { HttpClientComponent } from '../http/http.component';
import { HttpClient } from '@angular/common/http';
import {SharedInternalData} from '../sharedData/sharedData';

@Component({
  selector: 'app-search-patient',
  templateUrl: './search-patient.component.html',
  styleUrls: ['./search-patient.component.css']
})
export class SearchPatientComponent implements OnInit {
  @Output() patientList = new EventEmitter<String>();

  constructor(private _httpClientComponent: HttpClientComponent,private _sharedService:SharedInternalData) { }

  ngOnInit(): void {
  }

  onSearchType(value: string) {
    this.getPatientListFromBackend(value);
  }

  getPatientListFromBackend(value: string) {
    this._httpClientComponent.get('https://localhost:44351/api/Patient/search?searchString=' + value)
      .subscribe((result) => {
        this.patientList = result;
        this._sharedService.onPatientListChange(this.patientList);
        console.log(result);
      });
  }
}
