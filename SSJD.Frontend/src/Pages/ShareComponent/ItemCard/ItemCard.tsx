/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useEffect, useState } from "react"
import './ItemCard.css'
import logoimg from '../../../Image/logo.jpg'
import { ProductModel } from "../../../Model/Product/ProductModel"
import { get } from "http"
import { useShoppingCart } from "../../../Hooks/useShoppingCart"
import { useNavigate } from "react-router-dom"

interface props{
  products : ProductModel
}

const ItemCard:React.FC<props> = ({products}) =>{
  const { increaseCartQuantity} = useShoppingCart()
  const [selectheadtype, setselectheadtype] = useState<string>("");
  const apiUrl = import.meta.env.VITE_API_GET_IMG;
  const navigate = useNavigate()
  function NavtoDetail(){
    navigate(`/productdetail/${products.id}`);
  }
    return (
    <div className="card text-center mx-auto" style={{ width: "18rem", border: "2px solid black", borderRadius: "10px" }}>
      <div onClick={NavtoDetail} className="card-img p-3">
        <img src={`${apiUrl}${products.image}`} className="img-fluid" />
      </div>
      <div className="card-body">
        <h5 className="card-title">{products.name}</h5>
        <p className="card-subtitle mb-2 text-muted">{products.brand}</p>
        <div className="card-text">
          <p className="fw-bold text-danger">{products.price} vnd</p>
          <div className="card-text-type-size d-flex flex-column">
            <div>
              <div className="d-flex flex-row gap-3"> 
                <div> 
                  <label className="d-block text-start fw-bold">Types</label>
                  <div className="list-unstyled text-start d-flex flex-row gap-2">
                      <span>{products.category}</span>             
                  </div>
                </div>
                <div className="product-detail-tips-card d-flex flex-row gap-3 mt-3">
                        <div onClick={() =>setselectheadtype('brushchisel')} className={`product-detail-tips-options-card ${selectheadtype === 'brushchisel' ? 'selected' : ''}`} >
                            <span>Chisel</span>
                        </div>
                        <div onClick={() =>setselectheadtype('brushfine')} className={`product-detail-tips-options-card ${selectheadtype === 'brushfine' ? 'selected' : ''}`}>
                            <span>Fine</span>
                        </div>
                  </div>
              </div>
            </div>
            <div>        
                <label className="d-block text-start fw-bold">Size</label>
                <ul className="list-unstyled text-start d-flex flex-row gap-2">
                    <li>{products.size}</li>
                </ul>
            </div>
          </div>
        </div>
        <div>
          <button onClick={() => increaseCartQuantity(products.id,selectheadtype)} className="card-add-to-card btn btn-pink text-white">
            Add to Cart
          </button>
        </div>
      </div>
    </div>
    )
}






export default ItemCard