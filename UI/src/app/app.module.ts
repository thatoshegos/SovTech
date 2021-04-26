import { SharedService } from './shared.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ChuckSwapiComponent } from './chuck-swapi/chuck-swapi.component';

import {HttpClientModule} from "@angular/common/http";
import { StarWarsComponent } from './star-wars/star-wars.component';
import { JokeComponent } from './joke/joke.component';
import { SearchComponent } from './search/search.component';



@NgModule({
  declarations: [
    AppComponent,
    ChuckSwapiComponent,
    StarWarsComponent,
    JokeComponent,
    SearchComponent, 
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
