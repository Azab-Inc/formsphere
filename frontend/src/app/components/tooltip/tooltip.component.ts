import { CommonModule } from '@angular/common';
import { Component, Input, OnInit } from '@angular/core';

enum Position {
  Top = 'top',
  Left = 'left',
  Right = 'right',
  Bottom = 'bottom',
}

@Component({
  selector: 'app-tooltip',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './tooltip.component.html',
  styles: ``,
})
export class TooltipComponent implements OnInit {
  @Input() tooltipText: string = 'Tooltip text';
  @Input() position: Position | null = null;
  showTooltip: boolean = false;

  positionClass(): string {
    let output: string = '';
    switch (this.position) {
      case Position.Right:
        output = `left-6 top-0`;
        break;
      case Position.Left:
        output = 'right-6 top-0';
        break;
      default:
        return '';
        break;
    }
    return output;
  }

  ngOnInit(): void {}
}
