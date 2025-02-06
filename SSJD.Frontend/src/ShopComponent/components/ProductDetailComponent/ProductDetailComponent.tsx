/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useState } from "react"
import img from '../../../Image/logo.jpg'
import './ProductDetailComponent.css'
const ProductDetailComponent:React.FC = () =>{
    const itemstip = [
        { id: 1, name: "Brush & Chisel" },
        { id: 2, name: "Brush & Fine" },
      ];
    const [count,setcount] = useState(1)
    const increase = () => setcount(count+1)
    const decrease = () => {if(count>1) setcount(count-1)}
    return(
        <div>
            <div className="d-flex flex-row gap-5">
                <div className="product-detail-img col-6">
                    <img src={img}></img>
                    <img src={img}></img>
                </div>
                <div className="col-6">
                    <div className="product-detail-brand">
                        <span>Ohuhu Honolulu Colors</span>
                    </div>
                    <div className="product-detail-price">
                        <span>6.274.000</span>
                    </div>
                    <div className="product-detail-description d-flex flex-column mt-3 gap-3">
                        <div className="d-flex gap-2">
                            <i className="bi bi-flower3"></i>
                            <span>Dual tips, double fun</span>
                        </div>
                        <div className="d-flex gap-2">
                            <i className="bi bi-flower3"></i>
                            <span>Easy blending, no smudging</span>
                        </div>
                        
                    </div>
                    <div className="product-detail-tips d-flex flex-row gap-3 mt-3">
                        {itemstip.map((itemstip)=>(
                            <div className="product-detail-tips-options">
                                {itemstip.name}
                            </div>
                        ))}
                    </div>
                    <div className="product-detail-availability d-flex flex-column mt-3 gap-2">
                        <span className="product-detail-availability-avai">Availability</span>
                        <span>Pre-Order</span>
                    </div>
                    <div className="product-detail-quantity mt-3">
                        <span >Quantity</span>
                        <div className="product-detail-quantity-count d-flex gap-2 justify-content-center align-items-center">
                            <i className="bi bi-dash product-detail-quantity-click" onClick={decrease}></i>
                            <span className="">{count}</span>
                            <i className="bi bi-plus product-detail-quantity-click" onClick={increase}></i>
                        </div>
                    </div>
                    <div className="mt-5">
                    <a href="#" className="product-detail-quantity-add-to-card btn btn-pink text-white">
                        Add to Cart
                    </a>
                    </div>
                </div>
            </div>
        </div>
    )
}







export default ProductDetailComponent