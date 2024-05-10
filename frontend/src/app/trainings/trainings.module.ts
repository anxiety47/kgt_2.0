import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GoogleMapsModule } from '@angular/google-maps';
import { TableModule } from 'primeng/table';

import { SharedModule } from '../shared/shared.module';
import { TrainingsRoutingModule } from './trainings-routing.module';
import { TrainingMapComponent } from './components/dog-training/training-map/training-map.component';
import { TrainingsListComponent } from './components/trainings-list/trainings-list.component';
import { DogTrainingComponent } from './components/dog-training/dog-training.component';
import { DogTrainingDataComponent } from './components/dog-training/dog-training-data/dog-training-data.component';

@NgModule({
  declarations: [
    TrainingMapComponent,
    TrainingsListComponent,
    DogTrainingComponent,
    DogTrainingDataComponent
  ],
  imports: [
    CommonModule,
    TableModule,
    TrainingsRoutingModule,
    GoogleMapsModule,
    SharedModule,
  ]
})
export class TrainingsModule { }
