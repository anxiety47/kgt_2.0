import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TrainingMapComponent } from './trainings/training-map/training-map.component';
import { TrainingComponent } from './trainings/training/training.component';
import { TrainingsListComponent } from './trainings/trainings-list/trainings-list.component';

const routes: Routes = [
  { path: '', component: TrainingsListComponent },
  { path: 'training', component: TrainingComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
