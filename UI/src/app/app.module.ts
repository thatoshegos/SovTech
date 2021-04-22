import { SharedService } from './shared.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ChuckSwapiComponent } from './chuck-swapi/chuck-swapi.component';

import {HttpClientModule} from "@angular/common/http";
import { StarWarsComponent } from './star-wars/star-wars.component';



@NgModule({
  declarations: [
    AppComponent,
    ChuckSwapiComponent,
    StarWarsComponent, 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
