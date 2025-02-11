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
  getItemQuantity: (productID: string) => number;
  increaseCartQuantity: (productID: string) => void;
  decreaseCartQuantity: (productID: string) => void;
  removeFromCart: (productID: string) => void;
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

  function increaseCartQuantity(productID: string) {
    setCart((currItems) => {
      if (currItems.find((item) => item.productID === productID) == null) {
        return [...currItems, { productID, quantity: 1 }];
      } else {
        return currItems.map((item) => {
          if (item.productID === productID) {
            return { ...item, quantity: item.quantity + 1 };
          } else {
            return item;
          }
        });
      }
    });
  }
  
  useEffect(() => {
    localStorage.setItem("shopping-cart", JSON.stringify(cart));

  }, [cart]);
  
  function decreaseCartQuantity(productID: string) {
    setCart((currItems) => {
      if (currItems.find((item) => item.productID === productID)?.quantity === 1) {
        return currItems.filter((item) => item.productID !== productID);
      } else {
        return currItems.map((item) => {
          if (item.productID === productID) {
            return { ...item, quantity: item.quantity - 1 };
          } else {
            return item;
          }
        });
      }
    });
  }
  

  function removeFromCart(productID: string) {
    setCart((currItems) => {
      return currItems.filter((item) => item.productID !== productID);
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
