import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-training-details',
  templateUrl: './training-details.component.html',
  styleUrls: ['./training-details.component.scss']
})
export class TrainingDetailsComponent {

  public dogsList = [{name: 'Dog1', note: 'trening 1'}, { name: 'Dog1', note: 'trening 2'}, { name: 'Dog2', note: 'trening 1'}];
  public trainingData = {
    date: '2024-10-23T10:32:00Z',
    location: 'training location',
    address: 'training address'
  }

  constructor(private router: Router) {}

  goToDogTraining(): void {
    this.router.navigate(['dog-training']);
  }

  public addDogToTraining(): void {
    this.router.navigate(['add-dog-to-training']);
  }

  public editTraining(): void {
    this.router.navigate(['edit-training']);
  }
}
