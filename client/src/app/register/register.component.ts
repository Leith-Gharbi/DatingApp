import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  @Input() UsersFromHomeComponent: any;
  model: any = {};
  constructor() {}

  ngOnInit(): void {}

  register() {
    console.log(this.model);
  }
  cancel() {
    console.log('canceled');
  }
}
