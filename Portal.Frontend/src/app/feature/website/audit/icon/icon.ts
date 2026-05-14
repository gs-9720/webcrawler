import { Component, Input } from '@angular/core';

@Component({
  selector: 'website-audit-icon',
  standalone: false,
  templateUrl: './icon.html',
})
export class WebsiteAuditIconComponent {
  @Input() success = false;
  @Input() error = false;
  @Input() warning = false;
  constructor() {
  }
}
