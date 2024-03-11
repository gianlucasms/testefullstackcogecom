// app.module.ts
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CooperadoListComponent } from './pages/cooperado-list/cooperado-list.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { CooperadoModalComponent } from './pages/cooperado-modal/cooperado-modal.component';
import { CooperadoModalModule } from './pages/cooperado-modal/cooperado-modal.module';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap'; 
@NgModule({
  declarations: [
    AppComponent,
    CooperadoListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    ReactiveFormsModule,
    CooperadoModalModule,
  ],
  providers: [NgbActiveModal], 
  bootstrap: [AppComponent]
})
export class AppModule {}
