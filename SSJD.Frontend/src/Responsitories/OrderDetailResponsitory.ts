/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable @typescript-eslint/no-unused-vars */
import axios from 'axios'


const apiUrl = import.meta.env.VITE_API_URL;


export const getOrderDetail = async()=>{
    const response = await axios.get(`${apiUrl}/OrderDetail`)
    console.log(response.data)
    return response.data
}

export const getCOrderDetailByID = async(id : string)=>{
    const response = await axios.get(`${apiUrl}/OrderDetail/${id}`)
    return response.data
}

export const createOrderDetail = async(data:any)=>{
    const response = await axios.post(`${apiUrl}/OrderDetail/CreateOrderDetail`)
    return response.data
}

export const editOrderDetail = async(data:any)=>{
    const response = await axios.put(`${apiUrl}/OrderDetail/EditOrderDetail`)
    return response.data
}

export const deleteOrderDetail = async(id : string)=>{
    const response = await axios.delete(`${apiUrl}/OrderDetail?id=${id}`)
    return response.data
}