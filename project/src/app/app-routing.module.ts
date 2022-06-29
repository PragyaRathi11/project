import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
//import { AdminComponent } from './Admin/admin.component';
import { HomeComponent } from './home/home.component';
import { ProductComponent } from './product/product.component';
import { UserComponent } from './user/user.component';

const routes: Routes = [
{path:'home',component:HomeComponent},
{path:'product',component:ProductComponent},
{path:'user', component:UserComponent},
//{path: 'admin',component:AdminComponent},
{path: 'cart',component:ProductComponent}

];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
