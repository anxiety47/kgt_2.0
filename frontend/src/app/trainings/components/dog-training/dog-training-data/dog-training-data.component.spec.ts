import { ComponentFixture, TestBed } from '@angular/core/testing';
import { DogTrainingDataComponent } from './dog-training-data.component';
import { TrainingsModule } from 'src/app/trainings/trainings.module';

describe('DogTrainingDataComponent', () => {
  let component: DogTrainingDataComponent;
  let fixture: ComponentFixture<DogTrainingDataComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DogTrainingDataComponent],
      imports: [TrainingsModule],
    });
    fixture = TestBed.createComponent(DogTrainingDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
