/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable @typescript-eslint/no-unused-vars */
import axios from 'axios'


const apiUrl = import.meta.env.VITE_API_URL;


export const getOrder = async()=>{
    const response = await axios.get(`${apiUrl}/Order`)
    console.log(response.data)
    return response.data
}

export const getOrderByID = async(id : string)=>{
    const response = await axios.get(`${apiUrl}/Order/${id}`)
    return response.data
}

export const createOrder = async(data:any)=>{
    const response = await axios.post(`${apiUrl}/Order/CreateOrder`)
    return response.data
}

export const editOrder= async(data:any)=>{
    const response = await axios.put(`${apiUrl}/Order/EditOrder`)
    return response.data
}

export const deleteOrder = async(id : string)=>{
    const response = await axios.delete(`${apiUrl}/Order?${id}`)
    return response.data
}