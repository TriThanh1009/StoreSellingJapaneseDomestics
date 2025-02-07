
import React from 'react';
import HomeComponent from '../../Pages/ShopComponent/components/HomeComponent/HomeComponent';
import Login from '../../Pages/AuthenticateComponent/Login/Login';
import Register from '../../Pages/AuthenticateComponent/Register/Register';
import ProductDetailComponent from '../../Pages/ShopComponent/components/ProductDetailComponent/ProductDetailComponent';
import { ProfileComponent } from '../../Pages/ShopComponent/components/ProfileComponent/ProfileComponent';
import Forgotpassword from '../../Pages/AuthenticateComponent/ForgotPassword/forgotpassword';
import CartComponent from '../../Pages/ShopComponent/components/CartComponent/CartComponent';




interface RouteConfig{
    path:string;
    element: React.ReactNode;
    children?:RouteConfig[];
}

const routes: RouteConfig[]=[
    {path: '/home',element:<HomeComponent/>},
    {path:'/home/productdetail',element:<ProductDetailComponent/>},
    {path:'/login',element:<Login/>},
    {path:'/forgot',element:<Forgotpassword/>},
    {path:'/register',element:<Register/>},
    {path:'/profile',element:<ProfileComponent/>},
    {path:'/cart',element:<CartComponent/>},
]
export default routes