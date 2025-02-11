/* eslint-disable react-refresh/only-export-components */
/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { createContext, ReactNode, useEffect, useState } from "react";
import { OrderDetailModel } from "../../Model/OrderDetail/OrderDetailModel";


type CardProps = {
  children: ReactNode;
};

type CartContextType = {
  openCart: () => void;
  closeCart: () => void;
  getItemQuantity: (productId: string) => number;
  increaseCartQuantity: (productId: string) => void;
  decreaseCartQuantity: (productId: string) => void;
  removeFromCart: (productId: string) => void;
  cartQuantity: number;
  cart: OrderDetailModel[];
};

// Tạo Context
export const CartShoppingContext = createContext({} as CartContextType);

// Định nghĩa Provider
export function CartProvider({ children }: CardProps) {
  const [isopen, setisopen] = useState(false);
  const [cart, setCart] = useState<OrderDetailModel[]>(() => {
    const savedCart = localStorage.getItem("shopping-cart");
    return savedCart ? JSON.parse(savedCart) : [];
  });
  

  const cartQuantity = cart.reduce((quantity, item) => item.quantity + quantity, 0);

  const openCart = () => setisopen(true);
  const closeCart = () => setisopen(false);

  function getItemQuantity(productId: string) {
    return cart.find((item) => item.productID === productId)?.quantity || 0;
  }

  function increaseCartQuantity(productId: string) {
    setCart((currItems) => {
      if (currItems.find((item) => item.productID === productId) == null) {
        return [...currItems, { productId, quantity: 1 }];
      } else {
        return currItems.map((item) => {
          if (item.productID === productId) {
            return { ...item, quantity: item.quantity + 1 };
          } else {
            return item;
            
          }
        });
      }
    });
    console.log(cart)
    
  }
  useEffect(() => {
    localStorage.setItem("shopping-cart", JSON.stringify(cart));

  }, [cart]);
  
  function decreaseCartQuantity(productId: string) {
    setCart((currItems) => {
      if (currItems.find((item) => item.productID === productId)?.quantity === 1) {
        return currItems.filter((item) => item.productID !== productId);
      } else {
        return currItems.map((item) => {
          if (item.id === productId) {
            return { ...item, quantity: item.quantity - 1 };
          } else {
            return item;
          }
        });
      }
    });
  }

  function removeFromCart(id: string) {
    setCart((currItems) => {
      return currItems.filter((item) => item.productID !== id);
    });
  }

  return (
    <CartShoppingContext.Provider
      value={{
        getItemQuantity,
        increaseCartQuantity,
        decreaseCartQuantity,
        removeFromCart,
        openCart,
        closeCart,
        cart,
        cartQuantity,
      }}
    >
      {children}
    </CartShoppingContext.Provider>
  );
}
