import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TrainingsListComponent } from './trainings-list/trainings-list.component';
import { TrainingMapComponent } from './dog-training/training-map/training-map.component';
import { GoogleMapsModule } from '@angular/google-maps';
import { DogTrainingComponent } from './dog-training/dog-training.component';
import { DogTrainingDataComponent } from './dog-training/dog-training-data/dog-training-data.component';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [
    TrainingMapComponent,
    TrainingsListComponent,
    DogTrainingComponent,
    DogTrainingDataComponent
  ],
  imports: [
    CommonModule,
    GoogleMapsModule,
    SharedModule
  ]
})
export class TrainingsModule { }
