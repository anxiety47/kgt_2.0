import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TrainingsListComponent } from './trainings-list/trainings-list.component';
import { TrainingMapComponent } from './training-map/training-map.component';
import { GoogleMapsModule } from '@angular/google-maps';
import { TrainingComponent } from './training/training.component';

@NgModule({
  declarations: [
    TrainingMapComponent,
    TrainingsListComponent,
    TrainingComponent
  ],
  imports: [
    CommonModule,
    GoogleMapsModule
  ]
})
export class TrainingsModule { }
