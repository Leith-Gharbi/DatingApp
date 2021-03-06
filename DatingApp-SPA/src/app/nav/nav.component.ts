import { Component, OnInit } from '@angular/core';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
model: any = {};

  constructor(public authService: AuthService, private alertify: AlertifyService) { }

  ngOnInit() {
  }
  login(){
this.authService.login(this.model).subscribe(next => {
  this.alertify.success('Logged in successfully');
//console.log('Logged in successfully');
}, error =>{
  this.alertify.error(error);
  //console.log('Failed to login');
}
);
    // console.log(this.model);

  }

  loggedIn() {
    return this.authService.loggedIn();
    // const token = localStorage.getItem('token');
    // return !!token;
  }
  logout() {
    localStorage.removeItem('token');
    //console.log('logged out');
    this.alertify.message('logged out');
  }
}
