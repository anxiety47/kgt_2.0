import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { TrainingListItem } from '../../models/trainings';
import { trainingsList } from 'src/mocked-data/trainings';

// TODO: add to providers in trainings module?
@Injectable({
  providedIn: 'root'
})
export class TrainingsApiService {

  private readonly endpoint: string = "";

  constructor() {}

  getTrainingsList(): Observable<TrainingListItem[]> {
    return of(trainingsList);
  }
}


