import { Component, OnInit, Input } from '@angular/core';
import { FrameworkElement } from '../../controls/frameworkElement';

@Component({
  selector: 'htd-main-menu',
  templateUrl: './main-menu.component.html',
  styleUrls: ['./main-menu.component.less']
})
export class MainMenuComponent extends FrameworkElement implements OnInit {

  constructor() {
    super();
  }

  ngOnInit() {
  }

}
