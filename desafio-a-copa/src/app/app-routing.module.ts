import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GerarCopaComponent } from './gerar-copa/gerar-copa.component';
import { ResultadoCopaComponent } from './resultado-copa/resultado-copa.component';


const routes: Routes = [
  { path: 'gerar-copa', component: GerarCopaComponent },
  { path: 'resultado-copa/:resultado', component: ResultadoCopaComponent },
  { path: '', redirectTo: '/gerar-copa', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
