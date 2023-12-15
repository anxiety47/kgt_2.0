import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrainingMapComponent } from './training-map.component';

// mock google maps
xdescribe('TrainingMapComponent', () => {
  let component: TrainingMapComponent;
  let fixture: ComponentFixture<TrainingMapComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TrainingMapComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TrainingMapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
