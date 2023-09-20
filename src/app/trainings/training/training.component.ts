import { Component } from '@angular/core';
import { trainingData } from './training-data/training-data';

@Component({
  selector: 'app-training',
  templateUrl: './training.component.html',
  styleUrls: ['./training.component.scss']
})
export class TrainingComponent {
  points = trainingData.dogTrackData.dogTrackPoints;
  pointsBlue = trainingData.lostPersonTrackData.lostPersonTrackPoints;

  trainingData = trainingData;
}
