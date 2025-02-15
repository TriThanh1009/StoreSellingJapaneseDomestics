import { useEffect, useState } from "react";
import { BrowserRouter, Routes, Route, Navigate } from "react-router-dom";
import App from "./App";
import AppAdmin from "./AppAdmin";
import Login from "./Pages/AuthenticateComponent/Login/Login";
import { CartProvider } from "./Features/Context/CartShoppingContext";

const Main = () => {
  const [role, setRole] = useState(localStorage.getItem("role"));

  useEffect(() => {
    const handleStorageChange = () => {
      setRole(localStorage.getItem("role"));
    };

    window.addEventListener("storage", handleStorageChange);
    const invernal = setInterval(() => {
      setRole(localStorage.getItem('role'))
    }, 500);
    return () => {
      window.removeEventListener("storage", handleStorageChange);
      clearInterval(invernal)
    }
  }, []);

  return (
    <BrowserRouter>
      <CartProvider>
        <Routes>
          {!role ? (
            <Route path="*" element={<Navigate to="/login" replace />} />
          ) : role === "Admin" ? (
            <Route path="*" element={<AppAdmin />} />
          ) : (
            <Route path="*" element={<App />} />
          )}
          <Route path="/login" element={<Login />} />
        </Routes>
      </CartProvider>
    </BrowserRouter>
  );
};

export default Main;
