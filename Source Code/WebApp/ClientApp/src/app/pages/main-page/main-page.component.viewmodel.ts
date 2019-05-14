import { Date, DateType } from 'src/app/models/date';
import { DelegateCommand } from 'src/app/common/inputs/delegateCommand';

export class MainPageComponentViewModel {
  commands: DelegateCommand[] = [
    {
      name: "测试按钮",
      icon: "search",
      action: () => {
        this.date.day = 18;
      }
    },
    {
      name: "测试按钮",
      icon: "plus",
      action: () => {
        this.date.month = 6;
      }
    }
  ];

  date: Date = {
    type: DateType.BC,
    year: 2019,
    month: 5,
    day: 14
  };

  execute(command: DelegateCommand): void {
    command.action();
  }
}
