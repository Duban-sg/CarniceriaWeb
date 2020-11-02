
import { Component, Input, OnInit } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';


@Component({
  selector: 'app-carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.css']
})
export class CarouselComponent implements OnInit {

  images = [944, 1011, 984].map((n) => `https://picsum.photos/id/${n}/900/500`);

  imagenes:any[]=[
    {
      name: 'Carne 1A',
      img:'./assets/Imagenes/carneimg.jpg',
      desc:'La mejor carne del mundo'
    },
    {
      name: 'Pollo 1A',
      img:'./assets/Imagenes/polloimg.jpeg',
      desc:'La mejor pollo del mundo'
    }
  ];

  constructor(private _config:NgbCarouselConfig) {
    _config.interval = 3000;
  }
  

  ngOnInit(): void {

  }





}
