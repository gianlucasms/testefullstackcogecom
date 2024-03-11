import { Component, EventEmitter, Output } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-cooperado-modal',
  templateUrl: './cooperado-modal.component.html',
  styleUrls: ['./cooperado-modal.component.css']
})
export class CooperadoModalComponent {
  @Output() cooperadoCadastrado = new EventEmitter<any>();
  cooperadoForm: FormGroup;
  adicionarUnidadeConsumidora = false;

  constructor(public activeModal: NgbActiveModal, private fb: FormBuilder) {
    this.cooperadoForm = this.fb.group({
      nome: ['', Validators.required],
      telefone: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      adicionarUnidadeConsumidora: [false],
      codigo: [''],
      concessionaria: [''],
      cep: [''],
      logradouro: [''],
      bairro: [''],
      localidade: [''],
      uf: [''],
      numero: ['']
    });
  }

  toggleUnidadeConsumidora() {
    this.adicionarUnidadeConsumidora = !this.adicionarUnidadeConsumidora;
  }

  cadastrarCooperado() {
    this.cooperadoCadastrado.emit(this.cooperadoForm.value);
    this.activeModal.close();
  }
}
