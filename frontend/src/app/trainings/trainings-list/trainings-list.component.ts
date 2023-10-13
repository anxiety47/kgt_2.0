import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-trainings-list',
  templateUrl: './trainings-list.component.html',
  styleUrls: ['./trainings-list.component.scss']
})
export class TrainingsListComponent implements OnInit {

  constructor(private router: Router) {}

  public ngOnInit(): void {}

  public goToTraining(): void {
    this.router.navigate(['dog-training']);
  }
}
