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
    localStorage.setItem("accessToken",accessToken)
    localStorage.setItem("id",userid)
}

