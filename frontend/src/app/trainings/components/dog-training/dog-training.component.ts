import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { TrainingsApiService } from '../../services/trainings-api/trainings-api.service';
import { DogTraining } from '../../models/trainings';

@Component({
  selector: 'app-dog-training',
  templateUrl: './dog-training.component.html',
  styleUrls: ['./dog-training.component.scss']
})
export class DogTrainingComponent implements OnInit, OnDestroy {
  public trainingData!: DogTraining;
  private subscriptions: Subscription[] = [];

  constructor(private trainingsApiService: TrainingsApiService) {}

  public ngOnInit(): void {
    const id = ''; // get dog ID from route params
    this.subscriptions.push(this.trainingsApiService.getDogTrainingById(id).subscribe(training => {
      this.trainingData = training;
    }));
  }

  public ngOnDestroy(): void {
    this.subscriptions.forEach(sub => sub.unsubscribe());
  }
}
