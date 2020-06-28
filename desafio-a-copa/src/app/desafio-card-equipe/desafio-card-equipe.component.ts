import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Equipe } from '../equipes/equipe';

@Component({
  selector: 'app-desafio-card-equipe',
  templateUrl: './desafio-card-equipe.component.html',
  styleUrls: ['./desafio-card-equipe.component.css']
})
export class DesafioCardEquipeComponent implements OnInit {

  @Input() nomeEquipe: string
  @Input() siglaEquipe: string
  @Input() equipe: Equipe;
  @Input() desabilitado: boolean;

  @Output() onSelect = new EventEmitter();
  @Output() onChange = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  selectEvent(equipe: Equipe) {    
    this.onSelect.emit(equipe);  
  }

  changeEvent(equipe: Equipe){
    this.onChange.emit(equipe); 
  }

}
