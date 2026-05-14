import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuditComponent } from './audit/audit';



const routes: Routes = [
   {
     path:'', component: AuditComponent
   },
{
     path:'audit', component: AuditComponent
   },
];

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule],
  providers: []
})

export class WebsiteRoutingModule { }
