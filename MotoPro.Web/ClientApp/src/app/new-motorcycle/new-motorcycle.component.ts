import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'new-motorcycle',
  templateUrl: './new-motorcycle.component.html'
})
export class AddMotorcycleComponent {
  public makes: IMake[];
  public models: IModel[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<IMake[]>(baseUrl + 'api/makes').subscribe(result => {
      this.makes = result;
      console.log(this.makes);
    }, error => console.error(error));
  }
}

interface IMake {
  id: number;
  name: string;
  models: IMake[];
}
interface IModel {
  id: number;
  name: string;
}
