import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cooperado-list',
  templateUrl: './cooperado-list.component.html',
  styleUrls: ['./cooperado-list.component.css']
})
export class CooperadoListComponent {
  cooperados = [
    { id: 1, nome: 'Cooperado 1', telefone: '123-456-7890', email: 'cooperado1@example.com' },
    { id: 2, nome: 'Cooperado 2', telefone: '987-654-3210', email: 'cooperado2@example.com' }
  ];

  constructor(private router: Router) {}

  cadastrarCooperado() {
    this.router.navigate([{ outlets: { 'modal-outlet': ['cadastrar-cooperado'] } }]);
  }

  editarCooperado(cooperado: any) {
    console.log('Editar Cooperado', cooperado);
  }

  removerCooperado(cooperadoId: number) {
    console.log('Remover Cooperado', cooperadoId);
  }
}
