import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-resultado-card-equipe',
  templateUrl: './resultado-card-equipe.component.html',
  styleUrls: ['./resultado-card-equipe.component.css']
})
export class ResultadoCardEquipeComponent implements OnInit {

  @Input() posicao: number
  @Input() nomeEquipe: number
  
  constructor() { }

  ngOnInit(): void {
  }

}
