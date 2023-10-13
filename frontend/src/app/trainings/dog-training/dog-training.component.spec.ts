import { ComponentFixture, TestBed } from '@angular/core/testing';
import { NO_ERRORS_SCHEMA } from '@angular/core';

import { DogTrainingComponent } from './dog-training.component';

describe('TrainingComponent', () => {
  let component: DogTrainingComponent;
  let fixture: ComponentFixture<DogTrainingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DogTrainingComponent],
      schemas: [NO_ERRORS_SCHEMA],
    });
    fixture = TestBed.createComponent(DogTrainingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
