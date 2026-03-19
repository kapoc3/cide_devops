import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class GreetingService {
  private http = inject(HttpClient);
  private apiUrl = environment.apiUrl;

  getGreeting(name: string): Observable<string> {
    return this.http.get(`${this.apiUrl}/hello/${name}`, { responseType: 'text' });
  }
}
