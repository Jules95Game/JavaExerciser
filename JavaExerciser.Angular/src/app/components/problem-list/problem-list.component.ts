import { Component } from '@angular/core';
import Problem from '../../models/problem';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-problem-list',
  templateUrl: './problem-list.component.html',
  styleUrl: './problem-list.component.scss'
})
export class ProblemListComponent {

  //problems!: Problem[];
  //problems: Problem[] | undefined;
  problems: Problem[] = [];

  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
    this.httpClient.get<Problem[]>('https://localhost:7210/api/Problems')
      .subscribe((result: Problem[]) => {
        this.problems = result;
      });
  }
}
