import { ChuckSwapiComponent } from './chuck-swapi/chuck-swapi.component';
import {StarWarsComponent} from './star-wars/star-wars.component';
import {JokeComponent  } from './joke/joke.component';
import {SearchComponent  } from './search/search.component';
import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {path:"chuckswapi", component: ChuckSwapiComponent},
  {path:"starwars", component: StarWarsComponent},
  {path:"joke", component: JokeComponent},
  {path: "search", component: SearchComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
