import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CooperadoListComponent } from './cooperado-list.component';

describe('CooperadoListComponent', () => {
  let component: CooperadoListComponent;
  let fixture: ComponentFixture<CooperadoListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CooperadoListComponent]
    });
    fixture = TestBed.createComponent(CooperadoListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
