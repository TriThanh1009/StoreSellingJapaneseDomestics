/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable @typescript-eslint/no-unused-vars */
import axios from 'axios'

const apiUrl = import.meta.env.VITE_API_URL;


export const getProduct = async()=>{
    const response = await axios.get(`${apiUrl}/Product`)
    return response.data
}

export const getProductByID = async(id? : string)=>{
    const response = await axios.get(`${apiUrl}/Product/GetProductByID?id=${id}`)
    return response.data
}

export const createProduct = async(data:any)=>{
    const response = await axios.post(`${apiUrl}/Product/CreateProduct`)
    return response.data
}

export const editProduct = async(data:any)=>{
    const response = await axios.put(`${apiUrl}/Product/EditProduct`)
    return response.data
}

export const deleteProduct = async(id : string)=>{
    const response = await axios.delete(`${apiUrl}/Product?${id}`)
    return response.data
}