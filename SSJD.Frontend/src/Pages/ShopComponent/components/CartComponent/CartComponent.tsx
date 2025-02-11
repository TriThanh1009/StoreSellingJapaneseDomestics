/* eslint-disable @typescript-eslint/no-unused-vars */
/* eslint-disable @typescript-eslint/no-explicit-any */
import React, { useEffect, useState } from "react"
import { Button, Stack, Table } from "react-bootstrap";
import { useShoppingCart } from "../../../../Hooks/useShoppingCart";
import { getProductByID } from "../../../../Responsitories/ProductResponsitory";
import { OderDetailwithProduct } from "../../../../Model/OderWithProduct/OrderWithProduct";
import './CartComponent.css'



const CardComponent: React.FC = () => {
  const {cart,removeFromCart,decreaseCartQuantity,increaseCartQuantity} = useShoppingCart()
  const [orders,setorder] = useState<OderDetailwithProduct[]>()
  //const [products,setproducts] = useState<ProductModel[]>()
  useEffect(() => {
    
    const fetchOrders = async () => {
      if (cart.length === 0) return;
  
      const orderList: OderDetailwithProduct[] = await Promise.all(
        cart.map(async (item) => {
          const product = await getProductByID(item.productID);
          return { 
            product: product,  // Thông tin sản phẩm
            quantity: item.quantity // Lấy quantity từ cart
          }; 
        })
      );
  
      setorder(orderList); // Cập nhật orders
    };
  
    fetchOrders();
  }, [cart]);

  function handleRemove(id : string){
    console.log(id)
    removeFromCart(id)
    localStorage.removeItem("shopping-cart"); 
    orders?.filter(item=>item.product.id ===id)

    window.location.reload()
  }
    return (
      <div>
      <Stack>
        <div className="container mt-4">
        <h2>Shopping Cart</h2>
        <Table striped bordered hover>
          <thead>
            <tr>
              <th>Product</th>
              <th>Price</th>
              <th>Quantity</th>
              <th>Remove</th>
            </tr>
          </thead>
          <tbody>
            {Array.isArray(orders) && orders.map((order) => (
              <tr key={order.product.id}>
                <td>
                  <div className="d-flex align-items-center">
                    <div>
                      <strong>{order.product.name}</strong>
                      <br />
                      <small>Category: {order.product.category}</small>
                    </div>
                  </div>
                </td>
                <td>${order.product.price}</td>
                <td className="">
                  <i  onClick={()=>decreaseCartQuantity(order.product.id)} className="bi bi-caret-left"></i>
                  <span className="mx-2">{order.quantity}</span>
                  <i onClick={()=>increaseCartQuantity(order.product.id)} className="bi bi-caret-right"></i>
                </td>
                
                <td>
                  <Button
                    variant="danger"
                    size="sm"
                    onClick={() => handleRemove(order.product.id)}
                  >
                    🗑️
                  </Button>
                </td>
              </tr>
            ))}
          </tbody>
        </Table>
      </div>
      </Stack>
      <div className="shopping-cart-purchase d-flex justify-content-center align-items-center">
           <a href="#" className="product-detail-quantity-add-to-card btn btn-pink text-white">
                 Thanh toán
          </a>
              </div>
      </div>

    )
}



export default CardComponent