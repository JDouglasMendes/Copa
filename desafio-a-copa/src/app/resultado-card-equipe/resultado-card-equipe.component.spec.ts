import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResultadoCardEquipeComponent } from './resultado-card-equipe.component';

describe('ResultadoCardEquipeComponent', () => {
  let component: ResultadoCardEquipeComponent;
  let fixture: ComponentFixture<ResultadoCardEquipeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResultadoCardEquipeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResultadoCardEquipeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
