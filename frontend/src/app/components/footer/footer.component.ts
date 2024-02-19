import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './footer.component.html',
  styles: ``,
})
export class FooterComponent implements OnInit {
  constructor(private authService: AuthService) {}

  showFooter: boolean = false;

  ngOnInit(): void {
    this.showFooter = this.authService.getLoggedStatus();
  }
}
