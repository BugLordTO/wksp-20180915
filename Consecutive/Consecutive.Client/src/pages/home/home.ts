import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'page-home',
    templateUrl: 'home.html'
})
export class HomePage {

    input: string;
    result: number[] = [];

    constructor(public navCtrl: NavController, private http: HttpClient) {

    }

    calculate() {
        this.http.get<number[]>("http://node21.codenvy.io:40936/api/values/get/" + this.input)
            .subscribe(data => {
              console.log(data);
              this.result = data;
            });
    }
}
