import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TrainingsListComponent } from './trainings-list/trainings-list.component';
import { DogTrainingComponent } from './dog-training/dog-training.component';

const routes: Routes = [
  { path: '', component: TrainingsListComponent },
  { path: 'dog-training', component: DogTrainingComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TrainingsRoutingModule { }
