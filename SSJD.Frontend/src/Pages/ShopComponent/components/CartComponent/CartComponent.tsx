import React, { useState } from "react"
import { Button, Table } from "react-bootstrap";


const CardComponent:React.FC = () =>{
    const [cartItems,setCartItems] = useState([
        {
            id: 1,
            name: "Timex Unisex Originals",
            category: "Watches",
            price: 79.0,
            quantity: 3,
          },
          {
            id: 2,
            name: "Lumix camera lense",
            category: "Electronics",
            price: 79.0,
            quantity: 3,
          },
          {
            id: 3,
            name: "Gray Nike running shoe",
            category: "Fashion",
            price: 79.0,
            quantity: 3,
          },
    ])
    
      const handleRemove = (id: number) => {
        const updateCart = cartItems.filter((item => item.id !==id))
        setCartItems(updateCart)
        alert(`Removed item with id: ${id}`);
      };
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
            {cartItems.map((item) => (
              <tr key={item.id}>
                <td>
                  <div className="d-flex align-items-center">
                    <div>
                      <strong>{item.name}</strong>
                      <br />
                      <small>Category: {item.category}</small>
                    </div>
                  </div>
                </td>
                <td>${item.price.toFixed(2)}</td>
                <td>{item.quantity}</td>
                <td>
                  <Button
                    variant="danger"
                    size="sm"
                    onClick={() => handleRemove(item.id)}
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