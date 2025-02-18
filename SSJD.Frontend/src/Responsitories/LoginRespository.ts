/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable @typescript-eslint/no-unused-vars */
import axios from 'axios'
import { LoginModel } from '../Model/Login/LoginModel';
import { DecodeToken } from './TokenResponsitory';
import { jwtDecode } from 'jwt-decode';
const apiUrl = import.meta.env.VITE_API_URL;


export const LoginAccess = async(login? : LoginModel)=>{
    const response = await axios.post(`${apiUrl}/Login`,login,{
        headers:{
            "Content-Type" : "application/json"
        }
    })
    const accessToken = response.data.accessToken
    const userid = response.data.userID
    const decodeToken = jwtDecode<{[key:string]:any}>(accessToken)
    const role = decodeToken["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"]
    localStorage.setItem("accessToken",accessToken)
    localStorage.setItem("role",role)
    localStorage.setItem("id",userid)
}

