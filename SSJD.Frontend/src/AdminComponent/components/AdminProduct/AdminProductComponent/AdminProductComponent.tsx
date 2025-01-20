import React, { useEffect, useState } from "react"
import { ProductModel } from "../../../../Model/Product/ProductModel"
import { getProduct } from "../../../../Responsitory/ProductResponsitory"


const AdminProductComponent:React.FC = () =>{
    const [products,setproducts] = useState<ProductModel[]>()

    useEffect(()=>{
        const fetch = async()=>{
            const data = await getProduct()
            setproducts(data)
        }
        fetch()
    })
    return (
                    <div className="card shadow mb-4">
                        <div className="card-header py-3 d-flex flex-row justify-content-between">
                            <h6 className="m-0 font-weight-bold text-primary">Product Table</h6>
                            <button className="button-options">Create</button> 
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr className="t">
                                            <th>ID</th>
                                            <th>Name</th>
                                            <th>Brand</th>
                                            <th>Category</th>
                                            <th>Price</th>
                                            <th>Stock</th>
                                            <th>Active</th>
                                            <th>Image</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                        {Array.isArray(products) && products.map((product)=>(
                                            <tr>
                                                <td>{product.id}</td>
                                                <td>{product.name}</td>
                                                <td>{product.brand}</td>
                                                <td>{product.categoryID}</td>
                                                <td>{product.price}</td>
                                                <td>{product.stock}</td>
                                                <td>{product.isActive}</td>
                                                <td>{product.image}</td>
                                            </tr>
                                        ))}
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

    )
}


export default AdminProductComponent