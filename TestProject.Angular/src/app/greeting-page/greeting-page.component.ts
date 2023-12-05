import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import Greeting from '../models/greetings';

@Component({
  selector: 'app-greeting-page',
  templateUrl: './greeting-page.component.html',
  styleUrl: './greeting-page.component.scss'
})
export class GreetingPageComponent {

  greeting!: Greeting;

  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
    this.httpClient.get<Greeting>('https://localhost:7088/api/Greeting').subscribe((result: Greeting) => {
      this.greeting = result;
    });
  }
}
