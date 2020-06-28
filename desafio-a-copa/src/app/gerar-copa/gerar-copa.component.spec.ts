import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GerarCopaComponent } from './gerar-copa.component';

describe('GerarCopaComponent', () => {
  let component: GerarCopaComponent;
  let fixture: ComponentFixture<GerarCopaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GerarCopaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GerarCopaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
