import { TitleCasePipe } from '@angular/common';

 export class Equipe {
    id:string;
    nome:string;
    sigla:string;
    gols:number;
    selecionado:boolean;

    constructor(id,nome,sigla,gols){
      this.id=id;
      this.nome=nome;
      this.sigla=sigla;
      this.gols=gols;
      this.selecionado=false;
    }
 }