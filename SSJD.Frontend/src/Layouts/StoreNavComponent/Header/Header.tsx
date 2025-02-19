/* eslint-disable @typescript-eslint/no-unused-vars */
/* eslint-disable @typescript-eslint/no-explicit-any */

import './Header.css'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap-icons/font/bootstrap-icons.css';
import logoimg from '../../../Image/logo.jpg'
import logo from '../../../Image/chill.jpg'
import React, { useState } from 'react';
import { useShoppingCart } from '../../../Hooks/useShoppingCart';
import CartComponent from '../../../Pages/ShopComponent/components/CartComponent/CartComponent';
import { Navigate, useNavigate } from 'react-router-dom';

const Header:React.FC=()=>{
    const [showMenu, setShowMenu] = useState("");
    const [openDropdown,setopenDropdown] = useState(null)
    const {cartQuantity} = useShoppingCart()
    const navigate = useNavigate()
    function LogoutFeature(){
        localStorage.clear()
        window.location.reload()
      }
      const handleMenuClick = (menu: string) => {
        setShowMenu(prev => (prev === menu ? "" : menu));
    };
    function clicktonav(nav: string){
        navigate(`/${nav}`)
        setShowMenu("")
    }



    return(
    <div className="container d-flex justify-content-between">
        <div className='header-row-left d-flex gap-5 justify-content-start align-items-center'>
            <div className="logo">
                <img onClick={()=>clicktonav("home")} src={logoimg} ></img>
            </div>
            <div>
        <div className="options-dropdown-container">
                <div className="" onClick={() => handleMenuClick("markers")}>
                <span className='title' /> Markers
                </div>
                {showMenu ==="markers" && (
                <div className="options-dropdown-menu-logout d-flex flex-column gap-2">
                    <button onClick={()=>clicktonav("")} className="logout-button"></button>   
                    <button onClick={LogoutFeature} className="logout-button"></button>
                </div>
                )}
            </div>
        </div>
        <div>
            <div className="options-dropdown-container">
                <div className="account-image" onClick={() => handleMenuClick("artpaint")}>
                <span className='title' /> Arts and Paints
                </div>
                {showMenu ==="artpaint" && (
                    <div className="options-dropdown-menu-logout d-flex flex-column gap-2">
                    <button onClick={()=>clicktonav("")} className="logout-button"></button>   
                    <button onClick={LogoutFeature} className="logout-button"></button>
                </div>
                )}
            </div>
        </div>
        <div>
            <div className="options-dropdown-container">
                <div className="" onClick={() => handleMenuClick("support")}>
                <span className='title' /> Support
                </div>
                {showMenu ==="support" && (
                <div className="options-dropdown-menu-logout d-flex flex-column gap-2">
                    <button onClick={() => window.location.href = "https://www.facebook.com/Turtleeeeeeeeeeee/"}  className="logout-button">Facebook</button>   
                    <button onClick={()=>clicktonav("")} className="logout-button">Instagram</button>
                </div>
                )}
            </div>
        </div>
        </div>
        <div className='header-row-right d-flex justify-content-end align-items-center gap-3'>
            <div className='search'>
                 <i className="bi bi-search"></i>
            </div>
            <div className="account-container">
                {/* Ảnh đại diện */}
                <div className="account-image" onClick={() => handleMenuClick("logout")}>
                    <img src={logo}  />
                </div>

                {/* Menu Logout */}
                {showMenu==="logout" && (
                    <div className="dropdown-menu-logout d-flex flex-column gap-2">
                    <button onClick={()=>clicktonav("profile")} className="logout-button">Profile</button>   
                    <button onClick={LogoutFeature} className="logout-button">Logout</button>
                </div>
                )}
            </div>
            <div className='shopping-cart' onClick={()=>clicktonav("cart")}>
                <i className='cart bi bi-cart2'></i>
                <span className='shopping-cart-quantity'>{cartQuantity}</span>
                
            </div>
            
        </div>
    </div>

    )
}




export default Header