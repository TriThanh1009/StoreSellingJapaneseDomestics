/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable @typescript-eslint/no-unused-vars */
import axios from 'axios'


const apiUrl = process.env.REACT_APP_API_URL;


export const getAccount = async()=>{
    const response = await axios.get(`${apiUrl}/Account`)
    return response.data
}

export const getAccountByID = async(id : string)=>{
    const response = await axios.get(`${apiUrl}/Account/${id}`)
    return response.data
}

export const createAccount = async(data:any)=>{
    const response = await axios.post(`${apiUrl}/Account/CreateAccount`)
    return response.data
}

export const editAccount = async(data:any)=>{
    const response = await axios.put(`${apiUrl}/Account/EditAccount`)
    return response.data
}

export const deleteAccount = async(id : string)=>{
    const response = await axios.delete(`${apiUrl}/Account?${id}`)
    return response.data
}