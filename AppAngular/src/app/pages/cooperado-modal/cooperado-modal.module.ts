import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common'; 
import { CooperadoModalComponent } from './cooperado-modal.component';

@NgModule({
  declarations: [
    CooperadoModalComponent,
  ],
  imports: [
    ReactiveFormsModule,
    CommonModule,
  ],
  exports: [CooperadoModalComponent],  
})
export class CooperadoModalModule {}