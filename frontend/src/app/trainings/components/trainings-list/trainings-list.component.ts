import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TrainingListItem } from '../../models/trainings';
import { TrainingsApiService } from '../../services/trainings-api/trainings-api.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-trainings-list',
  templateUrl: './trainings-list.component.html',
  styleUrls: ['./trainings-list.component.scss']
})
export class TrainingsListComponent implements OnInit, OnDestroy {

  public trainingsList: TrainingListItem[] = [];
  private subscriptions: Subscription[] = [];

  constructor(
    private router: Router,
    private trainingsApiService: TrainingsApiService,
  ) {}

  public ngOnInit(): void {
    this.subscriptions.push(this.trainingsApiService.getTrainingsList().subscribe(trainings => {
      this.trainingsList = trainings;
    }));
  }

  public ngOnDestroy(): void {
    this.subscriptions.forEach(sub => sub.unsubscribe());
  }

  public goToTraining(): void {
    this.router.navigate(['training-details']);
  }

  public addDogToTraining(): void {
    console.log('add new dog to training list');
  }
}
