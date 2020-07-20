import { Component, Injectable, Input, Output, EventEmitter } from '@angular/core';
export interface myData {
}
@Injectable()
export class SharedInternalData {
    @Output() public updatePatient: EventEmitter<any> = new EventEmitter();
    @Output() public updatePatientList: EventEmitter<any> = new EventEmitter();

    public sharingPatientData: myData = {};
    public sharingPatientList: myData = {};

    savePatient(str) {
        this.sharingPatientData = str;
    }

    getPatient() {
        return this.sharingPatientData;
    }

    savePatientList(strarr) {
        this.sharingPatientList = strarr;
    }

    getPatientList() {
        return this.sharingPatientList;
    }
    
    onPatientChange(patient) {
        this.updatePatient.emit(patient);
    }

    onPatientListChange(strarr) {
        this.updatePatientList.emit(strarr);
    }
}