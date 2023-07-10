import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TrainingMapComponent } from './trainings/training-map/training-map.component';

const routes: Routes = [
  { path: '', component: TrainingMapComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
