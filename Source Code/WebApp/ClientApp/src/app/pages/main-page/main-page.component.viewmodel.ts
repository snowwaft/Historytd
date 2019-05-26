import { Date, DateType } from 'src/app/models/date';
import { DelegateCommand } from 'src/app/common/inputs/delegateCommand';

export class MainPageComponentViewModel {

  menus: MenuViewModel[] = [
    {
      name: "事件",
      children: [{
        name: "测试"
      }],
      command: {
        name: "添加事件",
        action: () => { }
      }
    },
    {
      name: "地点",
      command: {
        name: "添加地点",
        action: () => { }
      }
    },
    {
      name: "人物",
      command: {
        name: "添加人物",
        icon: "",
        action: () => { }
      }
    }
  ];

  gotoDateCommand: DelegateCommand = {
    name: "转到",
    icon: "goto",
    action: () => {
      this.date.day = 24;
    }
  }

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

export class MenuViewModel {
  name: string;
  children?: MenuViewModel[];
  command?: DelegateCommand;
}
