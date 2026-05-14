import { Component } from '@angular/core';
import { WebsiteService } from '../../../core/services/website.service';
import { ActivatedRoute, Router } from '@angular/router';
import { AuditReportModel } from '../../../core/models/auditReport';

@Component({
  selector: 'website-audit',
  standalone: false,
  templateUrl: './audit.html',
  styleUrl: './audit.css',
})
export class AuditComponent {
  constructor(private websiteService: WebsiteService, private route: ActivatedRoute, private router: Router) {

  }
  url = "";
  report! : AuditReportModel;
  isloading = true;
  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      if (params['url']) {
        this.url = params['url'];
        this.getAuditReport(params['url']);
      }
      else {
        this.router.navigate(['/']);
      }
    });
  }

  getAuditReport(url: string) {
    this.websiteService.getAuditReprot(url).subscribe((res : any) => {
      this.report = res;
      this.isloading = false;
    },
    (error) => {

      console.error('Error fetching audit report:', error);
    }
  );
  }
}
