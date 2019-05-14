import { Component, OnInit, Input } from '@angular/core';
import { Date, DateType } from 'src/app/models/date';

@Component({
  selector: 'htd-date-selector',
  templateUrl: './date-selector.component.html',
  styleUrls: ['./date-selector.component.less']
})
export class DateSelectorComponent implements OnInit {

  yearFormatter = (value: number) => `${value} 年`;
  yearParser = (value: string) => value.replace(' 年', '');

  @Input() date: Date = {
    type: DateType.BC,
    year: 2019,
    month: 5,
    day: 12
  };

  constructor() { }

  ngOnInit() {
  }

}
