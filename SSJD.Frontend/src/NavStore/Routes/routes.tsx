import Login from "../../AuthenticateComponent/Login/Login";
import React from 'react';
import Home from "../../ShopComponent/HomeComponent/Home";
import Forgot from "../../AuthenticateComponent/ForgotPassword/forgotpassword"
import Register from "../../AuthenticateComponent/Register/Register"

interface RouteConfig{
    path:string;
    element: React.ReactNode;
}

const routes: RouteConfig[]=[
    {path: '/',element:<Home/>},
    {path:'/login',element:<Login/>},
    {path:'/forgot',element:<Forgot/>},
    {path:'/register',element:<Register/>}
]
export default routes