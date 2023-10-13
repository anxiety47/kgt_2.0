import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { DogTraining } from '../../models/trainings';

@Component({
  selector: 'app-training-data',
  templateUrl: './dog-training-data.component.html',
  styleUrls: ['./dog-training-data.component.scss']
})
export class DogTrainingDataComponent implements OnInit {

  @Input() trainingData!: DogTraining;
  form: FormGroup = this.fb.group({
    personTrailLength: ['', Validators.required],
    personStartTime: ['', Validators.required],
    delayTime: ['', Validators.required],
    dogTrailLength: ['', Validators.required],
    dogStartTime: ['', Validators.required],
    duration: ['', Validators.required],
    personName: ['', Validators.required],
    notes: ['', Validators.required],
    weather: ['', Validators.required],
    groundType: ['', Validators.required],
  });;

  constructor(private fb: FormBuilder) {}

  ngOnInit(): void {

    this.form.patchValue({
      personTrailLength: this.trainingData.lostPersonTrackData.lostPersonTrailLength,
      personStartTime: this.trainingData.lostPersonTrackData.lostPersonStartTime,
      delayTime: this.trainingData.delayTime,
      dogTrailLength: this.trainingData.dogTrackData.dogTrailLength,
      dogStartTime: this.trainingData.dogTrackData.dogStartTime,
      duration: this.trainingData.duration,
      personName: this.trainingData.lostPersonTrackData.lostPersonName,
      notes: this.trainingData.notes,
      weather: this.trainingData.weather,
      groundType: this.trainingData.groundType
    });
  }
}
