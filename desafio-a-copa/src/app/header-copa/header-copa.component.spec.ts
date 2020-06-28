import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderCopaComponent } from './header-copa.component';

describe('HeaderCopaComponent', () => {
  let component: HeaderCopaComponent;
  let fixture: ComponentFixture<HeaderCopaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HeaderCopaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HeaderCopaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
