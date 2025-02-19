/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useEffect, useState } from "react"

import AdminProductOptionsComponent from "../AdminProductOptionsComponent/AdminProductOptionsComponent"
import './AdminProductComponent.css'
import { deleteProduct, getProduct } from "../../../../../Responsitories/ProductResponsitory"
import { ProductModel } from "../../../../../Model/Product/ProductModel"
import logo from '../../../../../../../Uploads/61f60849-bd68-457b-8efa-30c90a3dfcdb.jpg'
import { log } from "console"
const AdminProductComponent:React.FC = () =>{
    const apiUrl = import.meta.env.VITE_API_GET_IMG;
    const [products,setproducts] = useState<ProductModel[]>()
    const [getid,setgetid] = useState('');
     useEffect(()=>{
         const fetch = async()=>{
             const data = await getProduct()
             if(data)
                 setproducts(data)
            
         }
         fetch()
     })
    const [showformoptions, setShowFormOptions] = useState(false);
        let childpage
    const clicktoshowFormoption = ()=>{
        setgetid('')
        setShowFormOptions(true)
        console.log(showformoptions) 
        }
    const handleEdit = (id:string)=>{
            setShowFormOptions(true)
            setgetid(id)
            }
    const onDelete = async (id:string)=>{
            await deleteProduct(id)
            window.location.reload()
            }
    const onCancel = ()=>{
        setShowFormOptions(false)
        }
    if(showformoptions){
           childpage = <AdminProductOptionsComponent selectedID={getid} onCancel={onCancel} />
        } else childpage = <div></div>
    return (
                    <div className="card shadow mb-4">
                        <div className="card-header py-3 d-flex flex-row justify-content-between">
                            <h6 className="m-0 font-weight-bold text-primary">Product Table</h6>
                            <button className="button-options" onClick={clicktoshowFormoption}>Create</button> 
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr>
                                            <th>Name</th>
                                            <th>Brand</th>
                                            <th>Category</th>
                                            <th>Size</th>
                                            <th>Price</th>
                                            <th>Stock</th>
                                            <th>Active</th>
                                            <th>Image</th>
                                            <th>Options</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                        {Array.isArray(products) && products.map((product)=>(
                                            <tr key={product.id}>
                                                <td>{product.name}</td>
                                                <td>{product.brand}</td>
                                                <td>{product.category}</td>
                                                <td>{product.size}</td>
                                                <td>{product.price}</td>
                                                <td>{product.stock}</td>
                                                <td>{product.isActive}</td>
                                                <td className="product-list-img"><img src={`${apiUrl}${product.image}`}  /></td>
                                                <td className="td-options d-flex flex-row gap-2">
                                                <i onClick={()=>handleEdit(product.id)} className="options-icon bi bi-pen"></i>
                                                <i onClick={()=>onDelete(product.id)} className="options-icon bi bi-x-octagon"></i>
                                                </td>
                                            </tr>
                                        ))} 
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <div className="detail-page">
                                {childpage}
                        </div>
                    </div>

    )
}


export default AdminProductComponent