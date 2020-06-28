import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-header-copa',
  templateUrl: './header-copa.component.html',
  styleUrls: ['./header-copa.component.css']
})
export class HeaderCopaComponent implements OnInit {

  @Input() fase: string
  @Input() descricao: string
  @Input() complemento: string
  
  constructor() { }

  ngOnInit(): void {
  }

}
