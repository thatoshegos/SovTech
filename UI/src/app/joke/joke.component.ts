import { ChuckSwapiComponent } from './../chuck-swapi/chuck-swapi.component';
import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';


@Component({
  selector: 'app-joke',
  templateUrl: './joke.component.html',
  styleUrls: ['./joke.component.css']
})
export class JokeComponent implements OnInit {
  
  constructor(private service: SharedService ) { }
  
  ngOnInit(): void {
    
  }
}
