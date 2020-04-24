import { Component, OnInit } from '@angular/core';
import { User } from "../model/user";
import { UserService } from "../service/user.service";


@Component({
  selector: 'app-user',
  templateUrl: './user.component.html'
})
export class UserComponent implements OnInit {

  user: User = new User();
  users: User[];

  constructor(private userService: UserService) {
  }



  ngOnInit() {
    this.userService.getUsers().subscribe((data: User[]) => {
        this.users = data;
      },

      error => {
        for (var i = 0; i < error.length; i++) {
          alert(error[i]);
        }
      });

  }
}
