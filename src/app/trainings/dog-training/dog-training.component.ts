import { Component } from '@angular/core';
import { trainingData } from './training-data/training-data';

@Component({
  selector: 'app-dog-training',
  templateUrl: './dog-training.component.html',
  styleUrls: ['./dog-training.component.scss']
})
export class DogTrainingComponent {
  points = trainingData.dogTrackData.dogTrackPoints;
  pointsBlue = trainingData.lostPersonTrackData.lostPersonTrackPoints;

  trainingData = trainingData;
}
