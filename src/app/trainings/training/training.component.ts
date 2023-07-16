import { Component } from '@angular/core';
import { points, pointsBlue } from '../training-map/points';

@Component({
  selector: 'app-training',
  templateUrl: './training.component.html',
  styleUrls: ['./training.component.scss']
})
export class TrainingComponent {
  points = points;
  pointsBlue = pointsBlue;
}
