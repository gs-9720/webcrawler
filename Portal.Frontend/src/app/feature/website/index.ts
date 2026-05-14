import { NgModule, NO_ERRORS_SCHEMA } from "@angular/core";
import { AuditComponent } from "./audit/audit";
import { WebsiteRoutingModule } from "./routes";
import { CommonModule } from "@angular/common";
import { WebsiteAuditIconComponent } from "./audit/icon/icon";


@NgModule({
    declarations: [
        AuditComponent,
        WebsiteAuditIconComponent
    ],
    imports: [
        WebsiteRoutingModule,
        CommonModule
    ],
    exports: [
    ],
    schemas: [NO_ERRORS_SCHEMA],
    providers: []
})
export class WebsiteModule { }
