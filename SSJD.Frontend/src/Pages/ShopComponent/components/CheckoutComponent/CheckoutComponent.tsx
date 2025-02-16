/* eslint-disable @typescript-eslint/no-unused-vars */

import './CheckoutComponent.css'
import img from '../../../../Image/logo.jpg'
import { useEffect, useState } from 'react'
import { OrderDetailwithProduct } from '../../../../Model/OderWithProduct/OrderWithProduct'
import { useShoppingCart } from '../../../../Hooks/useShoppingCart'
import { getProductByID } from '../../../../Responsitories/ProductResponsitory'
import logomomo from '../../../../Image/logo_momo.jpg'
import logovcb from '../../../../Image/logo_vcb.jpg'
import { useNavigate } from 'react-router-dom'
const CheckoutComponent:React.FC = () =>{
    const {cart} = useShoppingCart()
    const [orders,setorders] = useState<OrderDetailwithProduct[]>()
    const [total,settotal] = useState(0)
    const [selected, setSelected] = useState<string>("");
    const navigate = useNavigate()
    useEffect(() => {    
        const fetchOrders = async () => {
          if (cart.length === 0) return;
      
          const orderList: OrderDetailwithProduct[] = await Promise.all(
            cart.map(async (item) => {
              const product = await getProductByID(item.productID);
              return { 
                product: product,  // Thông tin sản phẩm
                quantity: item.quantity // Lấy quantity từ cart
              }; 
            })
          );
      
          setorders(orderList); // Cập nhật orders      
        };
      
        fetchOrders();
      }, [cart]);

      //tinh tong tien
      useEffect(() => {
        if (orders && orders.length > 0) {
            const totalprice = orders.reduce((sum, order) => sum + Number(order.product.price) * order.quantity, 0);
            settotal(totalprice);
        }
    }, [orders]);

    function paymentRoute(method : string){
        navigate(`/payment/${method}`);
    }
    return(
        <div className='container d-flex flex-row gap-5'>
            <div className='login d-flex flex-column justify-content-center align-items-center'>
                <div className='title'>
                    <span>Thanh toán</span>
                </div>
                <div className='login-input'>
                    <div className='input-information d-flex flex-column justify-content-center gap-3'>
                        <input type='text' placeholder='Họ và tên'></input>
                        <input type='text' placeholder='Đia chỉ'></input>   
                        <input type='text' placeholder='Email'></input>
                        <input type='text' placeholder='Số điện thoại'></input>
                        <div className='checkout-payment-method d-flex flex-row gap-2'>
                        <img 
                            src={logomomo} 
                            alt="momo" 
                            className={`payment-img ${selected === 'momo' ? 'selected' : ''}`} 
                            onClick={() => setSelected('momo')} 
                        />
                            <img src={logovcb} alt='vcb' className={`payment-img ${selected === 'vcb' ? 'selected' : ''}`} 
                            onClick={() => setSelected('vcb')} />
                        </div>
                        <div className="d-flex justify-content-between align-items-center">
                            <div className='checkout-return-cart'>
                                <i className="bi bi-chevron-left"></i>
                                <span>Trở về giỏ hàng</span>
                            </div>
                            <button className='checkout-button' onClick={()=> paymentRoute(selected)}>Đến trang tiếp theo</button>
                        </div>
                        
                    </div>
                </div>
            </div>
            <div className="checkout-product-information d-flex flex-column gap-5">
                <div className='checkout-product d-flex flex-column gap-3'>
                    {Array.isArray(orders) && orders.map((order) => (
                        <div key={order.product.id} className="checkout-product-name-price d-flex flex-row justify-content-between align-items-center gap-2 ">
                            <div className='checkout-product-img'>
                                <img src={img}></img>
                            </div>
                            <div className="checkout-product-name d-flex flex-column">
                                <span className='checkout-product-name-detail'>{order.product.name}</span>
                                <span className='checkout-product-category-detail'>Category: {order.product.category}</span>
                            </div>
                            <div className="checkout-product-price mx-5">
                                <span>{(order.product.price) * order.quantity} VND</span>
                            </div>
                        </div>
                    ))}
                        <div className='checkout-product-total '>
                                <span className='checkout-product-total-title'>Tổng tiền: </span>
                                <span className='checkout-product-total-price'>{total} VND</span>
                        </div>
                </div>
                
            </div>
        </div>
    )
}





export default CheckoutComponent