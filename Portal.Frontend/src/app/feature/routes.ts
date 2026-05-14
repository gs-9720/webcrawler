import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home';
import { LayoutComponent } from './layout/layout';



const routes: Routes = [
    {
        path: '', component: LayoutComponent,
        children: [
            { path: '', component: HomeComponent },
            {
                path: 'website',
                loadChildren: () =>
                    import('./website').then(m => m.WebsiteModule)
            },
        ]
    },



];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    exports: [RouterModule],
    providers: []
})

export class HomeRoutingModule { }
