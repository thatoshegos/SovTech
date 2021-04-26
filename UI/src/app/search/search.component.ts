import { SharedService } from 'src/app/shared.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  constructor( private service: SharedService) { }
  public SearchResults: any[] =[];
  public search: string;
  ngOnInit(): void {
  }
  itemClick(item: any): void{
    this.service.getSearches(item).subscribe(data => {
        this.SearchResults = data["result"];
console.log(this.SearchResults);
      },(error) =>{
         console.log("Thato"+ error)
     })
  }
}
