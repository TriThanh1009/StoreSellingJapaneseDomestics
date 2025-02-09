import React, { useEffect, useState } from "react"
import './ItemCard.css'
import logoimg from '../../../Image/logo.jpg'
import { ProductModel } from "../../../Model/Product/ProductModel"
import { getProduct } from "../../../Responsitories/ProductResponsitory"

const ItemCard:React.FC = () =>{
  // const {addtoCard} = useCart()
    const [products,setproducts] = useState<ProductModel>()
    useEffect(()=>{
      const fetch = async() =>{
        const data = await getProduct()
        setproducts(data)
      }
      fetch()
    },[])
    
    return (
    <div className="card text-center mx-auto" style={{ width: "18rem", border: "2px solid black", borderRadius: "10px" }}>
      <div className="card-img p-3">
        <img src={logoimg} className="img-fluid" />
      </div>
      { Array.isArray(products) && products.map((product)=>(
      <div className="card-body">
        <h5 className="card-title">{product.name}</h5>
        <p className="card-subtitle mb-2 text-muted">{product.brand}</p>
        <div className="card-text">
          <p className="fw-bold text-danger">{product.price} vnd</p>
          <div className="card-text-type-size d-flex flex-column">
            <div>
                <label className="d-block text-start fw-bold">Types</label>
                <ul className="list-unstyled text-start d-flex flex-row gap-2">
                    <li>Marker</li>
                </ul>
            </div>
            <div>        
                <label className="d-block text-start fw-bold">Size</label>
                <ul className="list-unstyled text-start d-flex flex-row gap-2">
                    <li>60</li>
                    <li>120</li>
                </ul>
            </div>
          </div>
        </div>
        <div>
          <button className="card-add-to-card btn btn-pink text-white">
            Add to Cart
          </button>
        </div>
      </div>
    ))}
    </div>
    )
}






export default ItemCard