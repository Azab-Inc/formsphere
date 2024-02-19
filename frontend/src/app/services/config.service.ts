import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { serverUrl } from '../utils/feConfig';

@Injectable({
  providedIn: 'root',
})
export class ConfigService {
  isSetup: boolean = false;

  constructor(private http: HttpClient) {}

  checkIfSetup(): boolean {
    this.http.get(serverUrl + 'config');
    return this.isSetup;
  }
}
