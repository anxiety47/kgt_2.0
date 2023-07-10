import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TrainingsListComponent } from './trainings-list/trainings-list.component';
import { TrainingMapComponent } from './training-map/training-map.component';
import { GoogleMapsModule } from '@angular/google-maps';

@NgModule({
  declarations: [
    TrainingMapComponent,
    TrainingsListComponent
  ],
  imports: [
    CommonModule,
    GoogleMapsModule
  ]
})
export class TrainingsModule { }
