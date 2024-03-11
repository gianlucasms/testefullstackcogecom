import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CooperadoModalComponent } from './cooperado-modal.component';

describe('CooperadoModalComponent', () => {
  let component: CooperadoModalComponent;
  let fixture: ComponentFixture<CooperadoModalComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CooperadoModalComponent]
    });
    fixture = TestBed.createComponent(CooperadoModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
