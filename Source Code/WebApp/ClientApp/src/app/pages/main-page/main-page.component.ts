import { Component, OnInit } from '@angular/core';
import { MainPageComponentViewModel } from './main-page.component.viewmodel';


@Component({
  selector: 'htd-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.less']
})
export class MainPageComponent implements OnInit {

  constructor() {
    this.viewModel = new MainPageComponentViewModel();
  }

  viewModel: MainPageComponentViewModel;

  ngOnInit() {
  }

}

