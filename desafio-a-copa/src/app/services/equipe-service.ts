import { BaseService } from "./base-service";
import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Equipe } from '../equipes/equipe'
import { map } from 'rxjs/operators'

@Injectable({ providedIn: 'root' })
export class EquipeService extends BaseService {
    constructor(private http: HttpClient) {
        super();
    }
    
    get() {
        return this.http.get<Equipe[]>(`${this.apiUrl()}/equipe`)
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