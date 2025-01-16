import Login from "../../AuthenticateComponent/Login/Login";
import React from 'react';
import Forgot from "../../AuthenticateComponent/ForgotPassword/forgotpassword"
import Register from "../../AuthenticateComponent/Register/Register"
import { HomeComponent, ProfileComponent } from "../../ShopComponent/components";

interface RouteConfig{
    path:string;
    element: React.ReactNode;
}

const routes: RouteConfig[]=[
    {path: '/',element:<HomeComponent/>},
    {path:'/login',element:<Login/>},
    {path:'/forgot',element:<Forgot/>},
    {path:'/register',element:<Register/>},
    {path:'/profile',element:<ProfileComponent/>}
]
export default routes