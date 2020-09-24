import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.scss']
})
export class ValueComponent implements OnInit {
values: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues();
  }

getValues(){
this.http.get('https://localhost:44394/api/values').subscribe(Response => {
this.values = Response;
}, error => {
  console.log(error);
});

}
}
