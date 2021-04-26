import { Joke } from './joke';
import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Observable, throwError } from 'rxjs'
import { map, catchError } from 'rxjs/operators';



@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly ChuckAPIUrl = "https://localhost:44353/api/chuck/categories";
  readonly SwAPIUrl = "https://localhost:44353/api/swapi/people";
  readonly SearchAPIUrl = "https://localhost:44353/api/search?query=";
  readonly JokeByCategory = "https://localhost:44353/api/random/category?query";

  constructor(private http: HttpClient) { }

  getChuckJokeCategory():Observable<any[]>{
    return this.http.get<any>(this.ChuckAPIUrl);
  }

  getStarWarsPeople():Observable<any[]>{
    return this.http.get<any[]>(this.SwAPIUrl);
  }

  getSearches(query):Observable<any[]>{
    return this.http.get<any>("https://localhost:44353/api/search?query="+ query);
  }

  getJokesByCategory(query:string): Observable<any>{
           let headers = new Headers({
        'Content-Type':'application/json',
        'Access-Control-Allow-Origin':'*'
      })
           let options = {headers: headers}
    return this.http.get<any>("https://localhost:44353/api/random/category?query=" + query).pipe(
      map((data: Joke[]) =>{
        return data;
      }), catchError( error => {
        return throwError( 'Something went wrong!' );
      })
    );
  } 
}
