import { Component, OnInit } from '@angular/core';
import { MainPageComponentViewModel } from './main-page.component.viewmodel';
import { FrameworkElement } from '../../common/controls/frameworkElement';


@Component({
  selector: 'htd-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.less']
})
export class MainPageComponent extends FrameworkElement implements OnInit {

  constructor() {
    super();
    this.dataContext = new MainPageComponentViewModel();
  }

  ngOnInit() {
  }

}

