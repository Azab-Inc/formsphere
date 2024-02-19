import { Routes, Route } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { PageNotFoundComponent } from './pages/page-not-found/page-not-found.component';
import { LoginComponent } from './pages/login/login.component';
import { ConfigService } from './services/config.service';
import { inject } from '@angular/core';
import { configGuard } from './guards/config.guard';
import { SetupComponent } from './pages/setup/setup.component';

const trailTitle: string = ' | Formsphere';

const preEditedRoutes: Routes = [
  {
    title: 'Home',
    path: '',
    pathMatch: 'full',
    canActivate: [configGuard],
    component: HomeComponent,
  },
  {
    title: 'Login',
    path: 'login',
    pathMatch: 'full',
    canActivate: [configGuard],
    component: LoginComponent,
  },
  {
    title: 'Setup',
    path: 'setup',
    pathMatch: 'full',
    component: SetupComponent,
  },
  {
    title: '404',
    path: '**',
    canActivate: [configGuard],
    component: PageNotFoundComponent,
  },
];

preEditedRoutes.forEach((route: Route) => {
  route.title = route.title + trailTitle;
});

export const routes: Routes = preEditedRoutes;
