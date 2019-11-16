import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { DetallePagosComponent } from './components/detalle-pagos/detalle-pagos.component';
import { DetallePagoComponent } from './components/detalle-pagos/detalle-pago/detalle-pago.component';
import { DetallePagoListaComponent } from './components/detalle-pagos/detalle-pago-lista/detalle-pago-lista.component';
import { DetallePagoService } from './services/detalle-pago.service';
import{FormsModule, ReactiveFormsModule} from "@angular/forms";
import { PracticaComponent } from './components/practica/practica.component';

@NgModule({
  declarations: [
    AppComponent,
    DetallePagosComponent,
    DetallePagoComponent,
    DetallePagoListaComponent,
    PracticaComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [DetallePagoService],
  bootstrap: [AppComponent]
})
export class AppModule { }

