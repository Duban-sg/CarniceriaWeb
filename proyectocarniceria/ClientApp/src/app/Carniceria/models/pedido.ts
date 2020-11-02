import { Factura } from "./factura";

export class Pedido {
    pedidoID:number; 
    fecha:Date;
    factura:Factura;
    direccion:string;
    estados:string; 
}
