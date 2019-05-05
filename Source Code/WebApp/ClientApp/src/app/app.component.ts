import { Component } from '@angular/core';
import { NzLayoutModule } from 'ng-zorro-antd';
import {NgxAmapModule} from 'ngx-amap';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less']
})
export class AppComponent {
  title = 'ClientApp';
  isCollapsed = false;
  isReverseArrow = false;
  width = 200;
}
