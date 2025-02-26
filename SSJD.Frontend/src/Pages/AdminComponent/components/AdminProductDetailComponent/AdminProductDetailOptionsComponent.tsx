/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useState } from "react"
import { ProductDetailCreateModel } from "../../../../Model/ProductDetail/ProductDetailCreateModel"
import { createProductDetail } from "../../../../Responsitories/ProductDetailResponsitory"

interface props{
    onCancel: () =>void
    productID : string
}

const AdminProductDetailOptionsComponent:React.FC<props> = ({productID,onCancel})=>{
    const [productdetail,setproductdetail] = useState<ProductDetailCreateModel>()

    const handleChange = (e : React.ChangeEvent<HTMLInputElement>)=>{
        const {name,value} = e.target
        setproductdetail((prev)=>({
            ...prev,
            productID : productID,
            [name]: name === "description" ? value.split(",") : value,
        }))
        console.log(productdetail)
    }

    const handleSubmit = async()=>{
        if(productdetail){
            await createProductDetail(productdetail)
        }
    }

    return(
        <form className="form form-zindex" onSubmit={handleSubmit}>
         <div>
            <div className="form-group row"  >
                    <label className="col-sm-5 col-form-label">Description</label>
                    <div className="col-sm-12">
                    <input type="text" id="description"  name="description" onChange={handleChange}  className="form-control" />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Warranty</label>
                    <div className="col-sm-12">
                        <input type="text" id="warranty"  name="warranty"     pattern="[a-zA-Z ]+"  onChange={handleChange} className="form-control" />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Origin</label>
                    <div className="col-sm-12">
                        <input type="text" id="origin"   name="origin" onChange={handleChange} className="form-control" />

                    </div>
                </div>
                <div className='button-options-list d-flex flex-row gap-3' >
                    <button type='submit' className="button-options">Accept</button>
                    <button className="button-options" onClick={onCancel} >Cancel</button> 
                </div>
        </div>
        </form>
    )
}


export default AdminProductDetailOptionsComponent