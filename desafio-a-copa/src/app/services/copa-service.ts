import { BaseService } from "./base-service";
import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Equipe } from '../equipes/equipe'
import { map } from 'rxjs/operators'

@Injectable({ providedIn: 'root' })
export class CopaService extends BaseService {
    constructor(private http: HttpClient) {
        super();
    }

    post(equipes: Equipe[]) {
        return this.http.post<string>(`${this.apiUrl()}/copa/processar-copa`, equipes)
            .pipe(
                map(resultado => {
                    return resultado;
                })
            );
    }

    get(resultado: string) {
        return this.http.get<Equipe[]>(`${this.apiUrl()}/copa/resultado-copa/${resultado}`)
            .pipe(
                map(equipe => {
                    if (equipe == null) {
                        equipe = [];
                    }
                    return equipe;
                })
            );
    }
}