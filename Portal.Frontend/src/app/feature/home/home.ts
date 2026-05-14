import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  standalone: false,
  templateUrl: './home.html',
})
export class HomeComponent {
  constructor(private router : Router) { }

  websiteUrl: string = '';

  startAudit() {
    if (this.websiteUrl) {
      console.log(`Starting audit for: ${this.websiteUrl}`);
      this.router.navigate(['/website/audit'], { queryParams: { url: this.ensureHttp(this.websiteUrl) } });
    } else {
      console.warn('Please enter a valid website URL.');
    }
  }

  ensureHttp(url: string): string {
    if (!url) return url;
    const trimmedUrl = url.trim();
    if (/^https?:\/\//i.test(trimmedUrl)) {
      return trimmedUrl;
    }
    return `https://${trimmedUrl}`;
  }

}
