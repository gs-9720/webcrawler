import { NgModule, NO_ERRORS_SCHEMA } from "@angular/core";
import { HomeComponent } from "./home/home";
import { HomeRoutingModule } from "./routes";
import { LayoutComponent } from "./layout/layout";
import { HeaderComponent } from "./layout/header/header";
import { FooterComponent } from "./layout/footer/footer";
import { LayoutHelperComponent } from "./layout/helper/helper";
import { CommonModule } from "@angular/common";
import { FormsModule } from "@angular/forms";


@NgModule({
    declarations: [
        HomeComponent,
        LayoutComponent,
        HeaderComponent,
        FooterComponent,
        LayoutHelperComponent
    ],
    imports: [
        HomeRoutingModule,
        CommonModule,
        FormsModule
    ],
    exports: [
    ],
    schemas: [NO_ERRORS_SCHEMA],
    providers: []
})
export class FeatureModule { }
