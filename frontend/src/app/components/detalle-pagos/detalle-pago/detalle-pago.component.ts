import { Component, OnInit } from '@angular/core';
import { DetallePagoService } from 'src/app/services/detalle-pago.service';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-detalle-pago',
  templateUrl: './detalle-pago.component.html',
  styleUrls: ['./detalle-pago.component.css']
})
export class DetallePagoComponent implements OnInit {

  constructor(private service: DetallePagoService, private formBuilder:FormBuilder) { }
  exRegularLetras: any = "^[a-zA-Z ]*$";
  exRegularCorreo: any = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
  exRegularNumeros: any = "^[0-9]*$";
  //exRegularMMYY: any = "^((0[1-9])|(1[0-2]))\/((2009)|(20[1-2][0-9]))$";
  

  get NombrePropietario(){
    return this.service.formularioDetallePago.controls['NombrePropietario'];
  }
  get NumeroTarjeta(){
    return this.service.formularioDetallePago.controls['NumeroTarjeta'];
  }
  get FechaExpiracion(){
    return this.service.formularioDetallePago.controls['FechaExpiracion'];
  }
  get CVV(){
    return this.service.formularioDetallePago.controls['CVV'];
  }

  get IdTarjeta(){
    return this.service.formularioDetallePago.controls['IdTarjeta'];
  }
  ngOnInit() {
    this.service.formularioDetallePago = this.formBuilder.group({
      IdTarjeta:[0],
      NombrePropietario:["", [Validators.required, Validators.pattern(this.exRegularLetras)]],
      NumeroTarjeta:["", [Validators.required, Validators.minLength(16), Validators.maxLength(16), Validators.pattern(this.exRegularNumeros)]],
      FechaExpiracion:["", [Validators.required, Validators.minLength(5), Validators.maxLength(5)]],
      CVV:["", [Validators.required, Validators.minLength(4), Validators.maxLength(4), Validators.pattern(this.exRegularNumeros)]]

    });

  }

}
