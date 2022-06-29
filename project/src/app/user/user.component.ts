import { Component, OnInit } from '@angular/core';
import { UserData } from '../models/userdata';
import { AuthService } from '../service/auth.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
//obj created
  registerUserData:UserData=new UserData();
  constructor(private _auth:AuthService) { }

  ngOnInit(): void {
  }
  registerUser(){
this._auth.registerUser(this.registerUserData).subscribe(res=>{

},
err => console.log(err));
  }

}



