import { Component } from '@angular/core';
import { trainingData } from 'src/mocked-data/trainings';

@Component({
  selector: 'app-dog-training',
  templateUrl: './dog-training.component.html',
  styleUrls: ['./dog-training.component.scss']
})
export class DogTrainingComponent {
  dogTrailPoints = trainingData.dogTrackData.dogTrackPoints;
  personTrailPoints = trainingData.lostPersonTrackData.lostPersonTrackPoints;

  trainingData = trainingData;
}
