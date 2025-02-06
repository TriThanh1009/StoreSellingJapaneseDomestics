
import React from 'react';
import Login from '../../AuthenticateComponent/Login/Login';
import Register from '../../AuthenticateComponent/Register/Register';
import ForgotPassword from '../../AuthenticateComponent/ForgotPassword/forgotpassword';
import { ProfileComponent } from '../components/ProfileComponent/ProfileComponent';
import HomeComponent from '../components/HomeComponent/HomeComponent';
import ProductDetailComponent from '../components/ProductDetailComponent/ProductDetailComponent';



interface RouteConfig{
    path:string;
    element: React.ReactNode;
    children?:RouteConfig[];
}

const routes: RouteConfig[]=[
    {path: 'home',element:<HomeComponent/>},
    {path:'/home/productdetail',element:<ProductDetailComponent/>},
    {path:'/login',element:<Login/>},
    {path:'/forgot',element:<ForgotPassword/>},
    {path:'/register',element:<Register/>},
    {path:'/profile',element:<ProfileComponent/>},
]
export default routes