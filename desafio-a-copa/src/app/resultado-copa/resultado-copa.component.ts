import { Component, OnInit } from '@angular/core';
import { Equipe } from '../equipes/equipe';
import { ActivatedRoute } from '@angular/router';
import { CopaService } from '../services/copa-service';

@Component({
  selector: 'app-resultado-copa',
  templateUrl: './resultado-copa.component.html',
  styleUrls: ['./resultado-copa.component.css']
})
export class ResultadoCopaComponent implements OnInit {

  HEADER_FASE: string = "Resultado Final"
  HEADER_DESCRICAO: string = "Veja o resultado final da Copa de forma simples e rápida"  

  public equipesDaCopa:Array<Equipe>;
  
  constructor(private activatedRoute: ActivatedRoute,
    private copaService: CopaService) {
    this.equipesDaCopa = new Array<Equipe>();
  }

  ngOnInit(): void {
    const guid = this.activatedRoute.snapshot.paramMap.get('resultado');
    this.copaService.get(guid)
    .subscribe((resultado) => {
      if (resultado) {
        this.equipesDaCopa = resultado;
      }
    }, (error) => {
      console.log(error);
    });
  }

}
