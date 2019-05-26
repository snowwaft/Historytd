import { Input } from '@angular/core';

export class FrameworkElement {

  _dataContext: any;

  @Input() public get dataContext() {
    return this._dataContext;
  }

  @Input() public set dataContext(value: any) {
    this._dataContext = value;
  }

  onDataContextChanged(): void { }
}
