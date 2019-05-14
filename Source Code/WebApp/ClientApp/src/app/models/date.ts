
export enum DateType {
    BC = 0,
    AD = 1
}

export interface Date {
    type: DateType;
    year: number;
    month: number;
    day: number;
}