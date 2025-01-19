/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable @typescript-eslint/no-unused-vars */
import axios from 'axios'


const apiUrl = import.meta.env.VITE_API_URL;


export const getCategory = async()=>{
    const response = await axios.get(`${apiUrl}/Category`)
    console.log(response.data)
    return response.data
}

export const getCategoryByID = async(id : string)=>{
    const response = await axios.get(`${apiUrl}/Category/${id}`)
    return response.data
}

export const createCategory = async(data:any)=>{
    const response = await axios.post(`${apiUrl}/Category/CreateCategory`)
    return response.data
}

export const editCategory = async(data:any)=>{
    const response = await axios.put(`${apiUrl}/Category/EditCategory`)
    return response.data
}

export const deleteCategory = async(id : string)=>{
    const response = await axios.delete(`${apiUrl}/Category?${id}`)
    return response.data
}