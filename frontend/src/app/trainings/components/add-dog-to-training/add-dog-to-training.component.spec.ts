import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddDogToTrainingComponent } from './add-dog-to-training.component';

describe('AddDogToTrainingComponent', () => {
  let component: AddDogToTrainingComponent;
  let fixture: ComponentFixture<AddDogToTrainingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddDogToTrainingComponent]
    });
    fixture = TestBed.createComponent(AddDogToTrainingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
