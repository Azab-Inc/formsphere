import { inject } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  RouterStateSnapshot,
  Router,
} from '@angular/router';
import { ConfigService } from '../services/config.service';
import { SetupComponent } from '../pages/setup/setup.component';

export const configGuard = (
  route: ActivatedRouteSnapshot,
  state: RouterStateSnapshot,
  router: Router,
) => {
  const config = inject(ConfigService);

  if (config.checkIfSetup() == false) {
    router.navigate([SetupComponent]);
  } else {
  }
  return config.checkIfSetup();
};
