import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DogTrainingComponent } from './trainings/dog-training/dog-training.component';
import { TrainingsListComponent } from './trainings/trainings-list/trainings-list.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  // { path: 'trainings', component: TrainingsListComponent },
  // { path: 'dog-training', component: DogTrainingComponent}

  { path: '', component: HomeComponent },
  { 
    path: 'trainings', 
    loadChildren: () => import('./trainings/trainings.module').then(m => m.TrainingsModule)
  },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
