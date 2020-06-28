import { Component, OnInit } from '@angular/core';
import { Equipe } from '../equipes/equipe';
import { Router } from '@angular/router';
import { EquipeService } from '../services/equipe-service';
import { CopaService } from '../services/copa-service';

@Component({
  selector: 'app-gerar-copa',
  templateUrl: './gerar-copa.component.html',
  styleUrls: ['./gerar-copa.component.css']
})
export class GerarCopaComponent implements OnInit {

  public equipesDaCopa: Array<Equipe>;
  public equipesSelecionadas: Array<Equipe>;
  public mensagem: string;
  TAMANHO_ARRAY_EQUIPES: number = 8
  HEADER_FASE: string = "Fase de Seleção"
  HEADER_DESCRICAO: string = "Selecione 8 equipes que você deseja para competição e depois pressione o botão GERAR COPA"
  HEADER_COMPLEMENTO: string = "para prosseguir"

  constructor(private router: Router,
              private equipeService: EquipeService,
              private copaService: CopaService) {
    this.equipesSelecionadas = new Array<Equipe>();
  }

  ngOnInit(): void {
    this.equipesDaCopa = new Array<Equipe>();
    this.equipeService.get().subscribe((equipes: Equipe[]) => {
      this.equipesDaCopa = equipes
    }, (error) => {
      console.log(error);
    });
  }

  atualizeSelecionados(equipe: Equipe) {
    if (this.equipesSelecionadas.findIndex(e => e.id === equipe.id) >= 0) {
      this.equipesSelecionadas = this.equipesSelecionadas.filter((eq) => {
        return eq.id != equipe.id;
      })
      this.verifiqueQuantidadeEquipes();
      return;
    }
    this.equipesSelecionadas.push(equipe);
    this.verifiqueQuantidadeEquipes();
  }

  verifiqueQuantidadeEquipes(): void {
    if (this.equipesSelecionadas.length > this.TAMANHO_ARRAY_EQUIPES) {
      this.mensagem = "Apenas 8 equipes devem ser selecionadas!"
    } else {
      this.mensagem = ''
    }
  }

  gerarCopa(): void {
    this.copaService.post(this.equipesSelecionadas)
      .subscribe((resultado) => {
        if (resultado) {
          this.router.navigate(['/resultado-copa', resultado]);
        }
      }, (error) => {
        console.log(error);
      });

  }
}
