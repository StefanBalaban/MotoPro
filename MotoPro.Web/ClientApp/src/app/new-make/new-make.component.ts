import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl } from "@angular/forms";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-new-make',
  templateUrl: './new-make.component.html',
  styleUrls: ['./new-make.component.css']
})
export class NewMakeComponent {
  private make :IMake;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }
  
  form = new FormGroup({
    name: new FormControl('')
  });

  onSubmit() {
    this.make = {
      id: 0,
      name: this.form.value.name
    } as IMake;
    this.http.post(this.baseUrl + 'api/makes', this.make).subscribe(
      (res) => {
        this.make = res as IMake;
      } ,
      (res) => console.log(res));
    this.form.reset();
  }

}
