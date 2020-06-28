import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DesafioCardEquipeComponent } from './desafio-card-equipe/desafio-card-equipe.component';
import { FormsModule }   from '@angular/forms';
import { GerarCopaComponent } from './gerar-copa/gerar-copa.component';
import { ResultadoCopaComponent } from './resultado-copa/resultado-copa.component';
import { HeaderCopaComponent } from './header-copa/header-copa.component';
import { ResultadoCardEquipeComponent } from './resultado-card-equipe/resultado-card-equipe.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    DesafioCardEquipeComponent,
    GerarCopaComponent,
    ResultadoCopaComponent,
    HeaderCopaComponent,
    ResultadoCardEquipeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule, 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
