import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl } from '@angular/forms';



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
      this.form.setValue({ make: this.makes[0] });
    }, error => console.error(error));
  }

  form = new FormGroup({
    make: new FormControl(''),
    name: new FormControl(''),
    phone: new FormControl(''),
    email: new FormControl('')
  });

  

  onSubmit() {
    console.warn(this.form.value);
  }
}
