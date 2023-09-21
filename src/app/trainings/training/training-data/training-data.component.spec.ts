import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrainingDataComponent } from './training-data.component';
import { TrainingsModule } from '../../trainings.module';

describe('TrainingDataComponent', () => {
  let component: TrainingDataComponent;
  let fixture: ComponentFixture<TrainingDataComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TrainingDataComponent],
      imports: [TrainingsModule],
    });
    fixture = TestBed.createComponent(TrainingDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
