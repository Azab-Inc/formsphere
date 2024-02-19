import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  loggedIn: boolean = true;

  constructor() {}

  getLoggedStatus(): boolean {
    return this.loggedIn;
  }
}
