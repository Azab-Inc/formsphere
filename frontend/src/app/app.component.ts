import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet, RouterModule, Router } from '@angular/router';
import { NavComponent } from './components/nav/nav.component';
import { FooterComponent } from './components/footer/footer.component';
import { ConfigService } from './services/config.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    CommonModule,
    NavComponent,
    FooterComponent,
    RouterOutlet,
    RouterModule,
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
})
export class AppComponent implements OnInit {
  constructor(
    private configService: ConfigService,
    private router: Router,
  ) {}

  ngOnInit(): void {
    if (!this.configService.checkIfSetup()) {
      this.router.navigate(['setup']);
    }
  }
}
