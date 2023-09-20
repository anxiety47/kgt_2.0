import { Component, Input } from '@angular/core';
import { DogTraining } from '../../models/trainings';

@Component({
  selector: 'app-training-data',
  templateUrl: './training-data.component.html',
  styleUrls: ['./training-data.component.scss']
})
export class TrainingDataComponent {

  @Input() trainingData!: DogTraining;
}
