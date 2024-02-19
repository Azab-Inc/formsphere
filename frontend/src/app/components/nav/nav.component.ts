import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-nav',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './nav.component.html',
  styles: ``,
})
export class NavComponent implements OnInit {
  constructor(private authService: AuthService) {}

  showNav: boolean = false;

  ngOnInit(): void {
    this.showNav = this.authService.getLoggedStatus();
  }
}
