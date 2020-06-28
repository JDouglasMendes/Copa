import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DesafioCardEquipeComponent } from './desafio-card-equipe.component';

describe('DesafioCardEquipeComponent', () => {
  let component: DesafioCardEquipeComponent;
  let fixture: ComponentFixture<DesafioCardEquipeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DesafioCardEquipeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DesafioCardEquipeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
