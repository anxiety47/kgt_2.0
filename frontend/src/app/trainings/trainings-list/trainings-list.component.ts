import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TrainingListItem } from '../models/trainings';

// use column - dynamic table
interface Column {
  field: string;
  header: string;
}

const tmp: TrainingListItem[] = [{
  id: '1',
  date: new Date(),
  location: 'test',
  address: 'test'
}]

@Component({
  selector: 'app-trainings-list',
  templateUrl: './trainings-list.component.html',
  styleUrls: ['./trainings-list.component.scss']
})
export class TrainingsListComponent implements OnInit {

  public trainingsList: TrainingListItem[] = [];

  constructor(private router: Router) {}

  public ngOnInit(): void {
    this.trainingsList = tmp;
  }

  public goToTraining(): void {
    this.router.navigate(['dog-training']);
  }
}
