import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [FormsModule, HttpClientModule, CommonModule],
  templateUrl: './app.html',
  styleUrls: ['./app.css']
})
export class AppComponent {

  userInput: string = '';
  generatedSql: string = '';

  constructor(private http: HttpClient) { }

  generateSql() {
    const body = {
      userInput: this.userInput
    };

    this.http.post<any>('http://localhost:5243/api/sql/generate', body)
      .subscribe({
        next: (response) => {
          this.generatedSql = response.generatedSql;
        },
        error: (err) => {
          console.error(err);
          this.generatedSql = "Error calling API";
        }
      });
  }
}
