import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private _registerUrl="https://localhost:7022/apilogin/register";
  private _loginurl="https://localhost:7022/apiogin/login";

  constructor(private http:HttpClient) { }
registerUser(user: any)
{
  return this.http.post<any>(this._registerUrl, user);

}
loginUser(user: any){
  return this.http.post<any>(this. _loginurl,user);
}
}
