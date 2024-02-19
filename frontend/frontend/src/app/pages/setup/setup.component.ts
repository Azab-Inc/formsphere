import { Component, OnInit } from '@angular/core';
import { TooltipComponent } from '../../components/tooltip/tooltip.component';
import { serverUrl } from '../../utils/feConfig';

@Component({
  selector: 'app-setup',
  standalone: true,
  imports: [TooltipComponent],
  templateUrl: './setup.component.html',
})
export class SetupComponent {
  showDb: boolean = false;
  defaultHostname: string = 'localhost';
}
