import { Component } from '@angular/core';
import { Greeting } from './greeting/greeting';

@Component({
  selector: 'app-root',
  imports: [Greeting],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'frontend';
}
