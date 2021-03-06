import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  // Injecting HttpClient
  constructor(protected http: HttpClient) {}
  // ToDo [question: why use Observable]
  getAll(endpoint: string): Observable<any[]> {
    // don't work with JSON directly, instead working with strongly typed object

    // make a http request, you need to subscribe the response data.
    // Observable can be finite (one response) or infinite (multiple responses)
    return this.http
      .get(`${environment.apiUrl}${endpoint}`)
      .pipe(map((res) => res as any[]));
    // map: select, filter: where
  }
  getOne(endpoint: string): Observable<any> {
    return this.http
      .get(`${environment.apiUrl}${endpoint}`)
      .pipe(map((res) => res as any));
  }
  create(endpoint: string, model: any): Observable<any> {
    return this.http
      .post(`${environment.apiUrl}${endpoint}`, model)
      .pipe(map((res) => res as any));
  }
  update(endpoint: string, model: any): Observable<any> {
    return this.http
      .put(`${environment.apiUrl}${endpoint}`, model)
      .pipe(map((res) => res as any));
  }
  delete(endpoint: string, id: number): Observable<void> {
    return this.http.delete(`${environment.apiUrl}${endpoint}/${id}`).pipe(
      map((response) => {
        response;
      })
    );
  }
}
