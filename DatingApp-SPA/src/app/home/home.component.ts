import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
registerMode = false;
// values: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    // this.getValues();
  }
  registerToggle(){
      this.registerMode = true;
  }
  // getValues(){
  //   this.http.get('https://localhost:44394/api/values').subscribe(Response => {
  //   this.values = Response;
  //   //console.log(this.values);
  //   }, error => {
  //     console.log(error);
  //   });
  //   }
    cancelRegisterMode(registerMode: boolean){
       this.registerMode = registerMode;
    }
}
