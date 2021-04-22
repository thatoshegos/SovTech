import { Component, Input, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service'

@Component({
  selector: 'app-chuck-swapi',
  templateUrl: './chuck-swapi.component.html',
  styleUrls: ['./chuck-swapi.component.css']
})
export class ChuckSwapiComponent implements OnInit {

  constructor(private service: SharedService) { }

  ChuckJokeCategories: any = [];
  ChuckJokeByCategory : any = [];
  

  ngOnInit(): void {
    
    this.getChuckJokes();
    
  }
 getChuckJokes(){
   this.service.getChuckJokeCategory().subscribe(data => {
     this.ChuckJokeCategories = data; 
   })
 }
 getJokebyCategory(query){
   this.service.getJokesByCategory(query).subscribe(data =>{
     this.ChuckJokeByCategory = data;
   })
 }
}
