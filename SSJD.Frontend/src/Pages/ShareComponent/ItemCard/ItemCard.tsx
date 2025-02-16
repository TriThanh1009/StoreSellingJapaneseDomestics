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
  const navigate = useNavigate()
  function NavtoDetail(){
    navigate(`/productdetail/${products.id}`);
  }
    return (
    <div className="card text-center mx-auto" style={{ width: "18rem", border: "2px solid black", borderRadius: "10px" }}>
      <div onClick={NavtoDetail} className="card-img p-3">
        <img src={logoimg} className="img-fluid" />
      </div>
      <div className="card-body">
        <h5 className="card-title">{products.name}</h5>
        <p className="card-subtitle mb-2 text-muted">{products.brand}</p>
        <div className="card-text">
          <p className="fw-bold text-danger">{products.price} vnd</p>
          <div className="card-text-type-size d-flex flex-column">
            <div>
                <label className="d-block text-start fw-bold">Types</label>
                <ul className="list-unstyled text-start d-flex flex-row gap-2">
                    <li>{products.category}</li>
                </ul>
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
          <button onClick={() => increaseCartQuantity(products.id)} className="card-add-to-card btn btn-pink text-white">
            Add to Cart
          </button>
        </div>
      </div>
    </div>
    )
}






export default ItemCard