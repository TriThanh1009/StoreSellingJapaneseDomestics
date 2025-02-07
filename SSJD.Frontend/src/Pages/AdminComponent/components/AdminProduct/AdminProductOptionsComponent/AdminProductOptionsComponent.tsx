/* eslint-disable @typescript-eslint/no-unused-vars */
import { useState } from 'react';
import { ProductOptionsModel } from '../../../../../Model/Product/ProductOptionsModel';
import { editProduct, createProduct } from '../../../../../Responsitories/ProductResponsitory';

interface Props {
    onCancel: () => void; // Định nghĩa prop onCancels
    selectedID : string
  }

const AdminProductOptionsComponent:React.FC<Props> = ({onCancel,selectedID}) =>{
const [product, setproduct] = useState<ProductOptionsModel>()
    const handlechange = (e:React.ChangeEvent<HTMLInputElement>)=>{
        const {name,value} = e.target
        if(selectedID){
            setproduct(prev=>({
                ...prev,
                id:selectedID
            }))
        }
        setproduct((prev)=>({
            ...prev,
            [name]:value,
        }))
    }

    const handlesubmit = async (e:React.FormEvent)=>{
        e.preventDefault()
        try{
            if(selectedID) 
                await editProduct(product)
            await createProduct(product)
        } catch (error) {
            alert('Error');
        }
    }

    return (
        <form className="form form-zindex" onSubmit={handlesubmit} >
            <h1 className='text-center'>Create</h1>
        <div className='d-flex flex-row'>
            <div>
                <div className="form-group row" >
                    <label className="col-sm-5 col-form-label">ID</label>
                    <div className="col-sm-10">
                    <input type="text" id="id"  name="id" onChange={handlechange}  className="form-control" />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Name</label>
                    <div className="col-sm-10">
                        <input type="text" id="name"  name="name"  onChange={handlechange}   pattern="[a-zA-Z ]+"   className="form-control" />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Brand</label>
                    <div className="col-sm-10">
                        <input type="text" id="brand"   name="brand" onChange={handlechange} className="form-control" />

                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Category</label>
                    <div className="col-sm-10">
                        <input type="text" id="categoryID"   name="categoryID" onChange={handlechange}   className="form-control" />

                    </div>
                </div>
            </div>
            <div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Price</label>
                    <div className="col-sm-10">
                        <input type="text" id="price"   name="price" onChange={handlechange}   className="form-control" />

                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Stock</label>
                    <div className="col-sm-10">
                        <input type="text" id="stock"   name="stock"  onChange={handlechange}  className="form-control" />

                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Active</label>
                    <div className="col-sm-10">
                        <input type="text" id="isActive"   name="isActive"  onChange={handlechange}  className="form-control" />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Image</label>
                    <div className="col-sm-10">
                        <input type="text" id="image"   name="image" onChange={handlechange}   className="form-control" />
                    </div>
                </div>
                <div className='button-options-list d-flex flex-row gap-3' >
                    <button type='submit' className="button-options">Accept</button>
                    <button className="button-options" onClick={onCancel} >Cancel</button> 
                </div>
            </div>
           
        </div>
    </form>
    )
}



export default AdminProductOptionsComponent