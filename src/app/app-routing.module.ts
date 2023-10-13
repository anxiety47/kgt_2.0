import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TrainingMapComponent } from './trainings/dog-training/training-map/training-map.component';
import { DogTrainingComponent } from './trainings/dog-training/dog-training.component';
import { TrainingsListComponent } from './trainings/trainings-list/trainings-list.component';

const routes: Routes = [
  { path: '', component: TrainingsListComponent },
  { path: 'dog-training', component: DogTrainingComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
