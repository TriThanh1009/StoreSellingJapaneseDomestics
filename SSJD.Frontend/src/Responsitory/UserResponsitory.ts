/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable @typescript-eslint/no-unused-vars */
import axios from 'axios'

const apiUrl = import.meta.env.VITE_API_URL;


export const getUser = async()=>{
    const response = await axios.get(`${apiUrl}/User`)
    return response.data
}

export const getUserByID = async(id : string)=>{
    const response = await axios.get(`${apiUrl}/User/${id}`)
    return response.data
}

export const createUser = async(data:any)=>{
    const response = await axios.post(`${apiUrl}/User/CreateUser`)
    return response.data
}

export const editUser = async(data:any)=>{
    const response = await axios.put(`${apiUrl}/User/EditUser`)
    return response.data
}

export const deleteUser = async(id : string)=>{
    const response = await axios.delete(`${apiUrl}/User?${id}`)
    return response.data
}