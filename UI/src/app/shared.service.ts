import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Observable} from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly ChuckAPIUrl = "https://localhost:44353/api/chuck/categories";
  readonly SwAPIUrl = "https://localhost:44353/api/swapi/people";
  readonly SearchAPIUrl = "https://localhost:44353/api/search";
  readonly JokeByCategory = "https://localhost:44353/api​/random​/category";

  constructor(private http: HttpClient) { }

  getChuckJokeCategory():Observable<any[]>{
    return this.http.get<any>(this.ChuckAPIUrl);
  }

  getStarWarsPeople():Observable<any[]>{
    return this.http.get<any>(this.SwAPIUrl);
  }

  getSearches(query):Observable<any[]>{
    return this.http.get<any>(this.SearchAPIUrl + '?query='+ query);
  }

  getJokesByCategory(query): Observable<any[]>{
    return this.http.get<any>(this.JokeByCategory +'?query=' + query);
  }
}
