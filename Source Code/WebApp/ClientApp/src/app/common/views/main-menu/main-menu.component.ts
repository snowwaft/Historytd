import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'htd-main-menu',
  templateUrl: './main-menu.component.html',
  styleUrls: ['./main-menu.component.less']
})
export class MainMenuComponent implements OnInit {

  constructor() { }

  @Input() dataContext: any;

  ngOnInit() {
  }

}
