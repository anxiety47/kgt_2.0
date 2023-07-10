import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TrainingsListComponent } from './trainings-list/trainings-list.component';
import { TrainingMapComponent } from './training-map/training-map.component';

@NgModule({
  declarations: [
    TrainingMapComponent,
    TrainingsListComponent
  ],
  imports: [
    CommonModule
  ]
})
export class TrainingsModule { }
