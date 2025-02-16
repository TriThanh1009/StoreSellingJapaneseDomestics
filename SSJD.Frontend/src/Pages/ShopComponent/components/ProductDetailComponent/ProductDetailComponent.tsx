/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useEffect, useState } from "react"
import img from '../../../../Image/logo.jpg'
import './ProductDetailComponent.css'
import { useNavigate, useParams } from "react-router-dom"
import { ProductModel } from "../../../../Model/Product/ProductModel"
import { getProductByID } from "../../../../Responsitories/ProductResponsitory"
import { useShoppingCart } from "../../../../Hooks/useShoppingCart"
const ProductDetailComponent:React.FC = () =>{
    const {increaseCartQuantity} = useShoppingCart()
    const {product} = useParams()
    const [takeproduct,settakeproduct] = useState<ProductModel>() 
    const navigate = useNavigate()
    useEffect(()=>{
        console.log(product)
        const fetch = async() =>{
            const data = await getProductByID(product)
            settakeproduct(data)
        }
        fetch()
    },[])
    const itemstip = [
        { id: 1, name: "Brush & Chisel" },
        { id: 2, name: "Brush & Fine" },
      ];
    const [count,setcount] = useState(1)
    const increase = () => {setcount(count+1)}
    const decrease = () => {if(count>1) setcount(count-1)}
    const handleAddToCart = () => {
        if (takeproduct?.id) {
            for (let i = 0; i < count; i++) {
                increaseCartQuantity(takeproduct.id);
            }
            navigate('/cart')
        }
    };
    return(
        <div>
            <div className="d-flex flex-row gap-5">
                <div className="product-detail-img col-6">
                    <img src={img}></img>
                    <img src={img}></img>
                </div>
                <div className="col-6">
                    <div className="product-detail-brand">
                        <span>{takeproduct?.name}</span>
                    </div>
                    <div className="product-detail-price">
                        <span>{takeproduct?.price}</span>
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
                    <button onClick={handleAddToCart} className="product-detail-quantity-add-to-card btn btn-pink text-white">
                        Add to Cart
                    </button>
                    </div>
                </div>
            </div>
        </div>
    )
}







export default ProductDetailComponent