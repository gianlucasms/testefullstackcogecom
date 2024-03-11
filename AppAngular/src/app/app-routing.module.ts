import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CooperadoListComponent } from './pages/cooperado-list/cooperado-list.component';
import { CooperadoModalComponent } from './pages/cooperado-modal/cooperado-modal.component';

const routes: Routes = [
  { path: '', redirectTo: '/cooperado-list', pathMatch: 'full' },
  { path: 'cooperado-list', component: CooperadoListComponent },
  { path: 'cadastrar-cooperado', component: CooperadoModalComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

