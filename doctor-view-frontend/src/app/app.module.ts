import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PatientlistComponent } from './patientlist/patientlist.component';
import { PatientheaderComponent } from './patientheader/patientheader.component';
import { FormsModule } from '@angular/forms';
import { DemographicsComponent } from './demographics/demographics.component';

@NgModule({
  declarations: [
    AppComponent,
    PatientlistComponent,
    PatientheaderComponent,
    DemographicsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
