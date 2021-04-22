import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service'

@Component({
  selector: 'app-star-wars',
  templateUrl: './star-wars.component.html',
  styleUrls: ['./star-wars.component.css']
})
export class StarWarsComponent implements OnInit {

  constructor(private service: SharedService) { }

  StarWarsPeople: any = [];

  ngOnInit(): void {

    this.getStarWarsPeopleList();
  }
  getStarWarsPeopleList(){
    this.service.getChuckJokeCategory().subscribe(data => {
      this.StarWarsPeople = data; })
    }

}
