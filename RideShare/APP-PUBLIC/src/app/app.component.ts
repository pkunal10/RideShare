import { Component } from '@angular/core';
import {AddressService} from '../Services/address.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  /**
   *
   */
  constructor(private _addressService:AddressService) {}

  title = 'Ride Share';
  msg= this._addressService.getAddress();
}
