import { HttpClient } from '@angular/common/http';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  @Input() UsersFromHomeComponent: any;
  @Output() cancelRegister = new EventEmitter();
  model: any = {};
  constructor() {}

  ngOnInit(): void {}

  register() {
    console.log(this.model);
  }
  cancel() {
    this.cancelRegister.emit(false);
    console.log('canceled');
  }
}
