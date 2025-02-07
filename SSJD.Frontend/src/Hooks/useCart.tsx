import { useContext } from "react";
import CartContext from "../Features/Context/CartContext";

// Hook để sử dụng CartContext
export const useCart = () => {
  const context = useContext(CartContext);
  if (!context) {
    throw new Error("useCart must be used within a CartProvider");
  }
  return context;
};