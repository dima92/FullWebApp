import { Component, OnInit } from '@angular/core';
import { CarService } from '../service/car.service';
import { Car } from '../model/car';


@Component({
  selector: 'app-car',
  templateUrl: './car.component.html'
})
export class CarComponent implements OnInit {

  car: Car = new Car();
  cars: Car[];

  constructor(private carService: CarService) {
  }

  ngOnInit() {
    this.carService.getCars().subscribe((data: Car[]) => {
        this.cars = data;
      },

      error => {
        for (var i = 0; i < error.length; i++) {
          alert(error[i]);
        }
      });
  }
}
