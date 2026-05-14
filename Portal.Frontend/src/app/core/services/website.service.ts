import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class WebsiteService {
  constructor(private http: HttpClient) { }
  // private baseUrl = "http://localhost:5284/api/";
  private baseUrl = "https://api.zwebsl.com/api/";

  getAuditReprot(url : string) {
    return this.http.get(this.baseUrl +`website-audit?url=${url}`);
  }
}
