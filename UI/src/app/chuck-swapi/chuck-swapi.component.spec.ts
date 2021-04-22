import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChuckSwapiComponent } from './chuck-swapi.component';

describe('ChuckSwapiComponent', () => {
  let component: ChuckSwapiComponent;
  let fixture: ComponentFixture<ChuckSwapiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChuckSwapiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChuckSwapiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
