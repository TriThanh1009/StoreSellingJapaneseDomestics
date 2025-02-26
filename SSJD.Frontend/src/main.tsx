/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable react-hooks/rules-of-hooks */
import { StrictMode } from "react"; // ✅ Import StrictMode
import { useEffect, useState } from "react";
import { BrowserRouter, Routes, Route, Navigate } from "react-router-dom";
import App from "./App";
import AppAdmin from "./AppAdmin";
import Login from "./Pages/AuthenticateComponent/Login/Login";
import { CartProvider } from "./Features/Context/CartShoppingContext";
import { createRoot } from "react-dom/client";
import Register from "./Pages/AuthenticateComponent/Register/Register";
import Forgotpassword from "./Pages/AuthenticateComponent/ForgotPassword/forgotpassword";
import { jwtDecode } from "jwt-decode";

const Main = () => {
  const [role, setRole] = useState(localStorage.getItem("role"));
  const [accessToken, setAccessToken] = useState(localStorage.getItem("accessToken"));
  useEffect(() => {
    if (accessToken) {
      try {
        const decodeToken = jwtDecode<{ [key: string]: any }>(accessToken);
        const getrole = decodeToken["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
        setRole(getrole); 
      } catch (error) {
        console.error("Lỗi khi giải mã token:", error);
        setRole(null);
      }
    } else {
      setRole(null);
    }
  }, [accessToken]) //Chỉ chạy khi accessToken thay đổi
  useEffect(() => {
    const handleStorageChange = () => {
      setAccessToken(localStorage.getItem("accessToken"));
    };
  
    window.addEventListener("storage", handleStorageChange);
  
    return () => {
      window.removeEventListener("storage", handleStorageChange);
    };
  }, []);
  

  return (
    <StrictMode>
      <BrowserRouter>
        <CartProvider>
          <Routes>
            <Route path="/login" element={<Login />} />
            <Route path="/register" element={<Register />} />
            <Route path="/forgot" element={<Forgotpassword />} />
            <Route path="*" element={<App />} />
            {!accessToken ? (
              <Route path="*" element={<Navigate to="/login" replace />} />
            ) : role === "Admin" ? (
              <Route path="*" element={<AppAdmin />} />
            ) : role === "Customer" ? (
              <Route path="*" element={<App />} />
            ): <Route path="*" element={<App />} />}
          </Routes>
        </CartProvider>
      </BrowserRouter>
    </StrictMode>
  );
};


createRoot(document.getElementById("root")!).render(<Main />);
