/* eslint-disable @typescript-eslint/no-unused-vars */
/* eslint-disable @typescript-eslint/no-explicit-any */
import React, { useEffect, useState } from "react"
import { Button, Table } from "react-bootstrap";
import { useShoppingCart } from "../../../../Hooks/useShoppingCart";
import { ProductModel } from "../../../../Model/Product/ProductModel";
import { getProductByID } from "../../../../Responsitories/ProductResponsitory";
import { OrderDetailModel } from "../../../../Model/OrderDetail/OrderDetailModel";



const CardComponent: React.FC = () => {
  const {cart,removeFromCart} = useShoppingCart()
  const [orders,setorder] = useState<OrderDetailModel[]>()
  const [products,setproducts] = useState<ProductModel[]>()
  useEffect(() => {
    const fetchProducts = async () => {
      if (cart.length === 0) return;

      const productList = await Promise.all(
        cart.map(async (item) => {
          return await getProductByID(item.id);
        })
      );
      setproducts(productList); 

    };
  
    fetchProducts();
  }, [cart]);

  function handleRemove(id : string){
    removeFromCart(id)
    localStorage.removeItem("shopping-cart"); 
    orders?.filter(item=>item.id ===id)

    window.location.reload()
  }
    return (
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
            {Array.isArray(products) && products.map((product) => (
              <tr key={product.id}>
                <td>
                  <div className="d-flex align-items-center">
                    <div>
                      <strong>{product.name}</strong>
                      <br />
                      <small>Category: {product.category}</small>
                    </div>
                  </div>
                </td>
                <td>${product.price}</td>
                <td>{product.price}</td>
                <td>
                  <Button
                    variant="danger"
                    size="sm"
                    onClick={() => handleRemove(product.id)}
                  >
                    🗑️
                  </Button>
                </td>
              </tr>
            ))}
          </tbody>
        </Table>
      </div>

    )
}



export default CardComponent