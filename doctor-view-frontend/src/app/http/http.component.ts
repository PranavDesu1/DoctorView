import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class HttpClientComponent {
    constructor(private http: HttpClient) {}
    get(url, headers?) :  Observable<any> {
        return this.http.get(url, headers);
    }
    post(url, payload,headers?) : Observable<any>  {
        return this.http.post(url, payload,headers);
    }
} 