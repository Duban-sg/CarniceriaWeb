import { Cliente } from "./cliente";
import { DetalleFactura } from "./DetalleFactura";

export class Factura {

    cliente:Cliente;
    fecha:Date;
    detallesFactura:DetalleFactura ;
    total:number;

}
