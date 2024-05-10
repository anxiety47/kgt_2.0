import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TrainingsListComponent } from './components/trainings-list/trainings-list.component';
import { DogTrainingComponent } from './components/dog-training/dog-training.component';
import { TrainingDetailsComponent } from './components/training-details/training-details.component';
import { AddDogToTrainingComponent } from './components/add-dog-to-training/add-dog-to-training.component';
import { EditTrainingComponent } from './components/edit-training/edit-training.component';

const routes: Routes = [
  { path: '', component: TrainingsListComponent },
  { path: 'dog-training', component: DogTrainingComponent},
  { path: 'training-details', component: TrainingDetailsComponent},
  { path: 'add-dog-to-training', component: AddDogToTrainingComponent},
  { path: 'edit-training', component: EditTrainingComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TrainingsRoutingModule { }
