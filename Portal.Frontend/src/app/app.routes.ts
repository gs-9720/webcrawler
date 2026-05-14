import { Routes } from '@angular/router';

// export const routes: Routes = [];


export const routes: Routes = [
    {
        path: '',
        loadChildren: () =>
            import('./feature').then(m => m.FeatureModule)
    },
    {
        path: '',
        redirectTo: '',
        pathMatch: 'full'
    }

];