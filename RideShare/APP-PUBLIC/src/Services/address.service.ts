import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AddressService {

  constructor() { }

  getAddress (){
    return "This is address results from service.";
  }

}
