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
    const [showMenu, setShowMenu] = useState(false);
    const [openDropdown,setopenDropdown] = useState(null)
    const {cartQuantity} = useShoppingCart()
    const navigate = useNavigate()
    const handleMouseEnter = (dropdownname:any) => {
        setopenDropdown(dropdownname);
    };
    const handleMouseLeave = () => {
        setopenDropdown(null);
    };
    const handleclick = (name:any)=>{
        window.location.href=name;
    }
    function LogoutFeature(){
        localStorage.clear()
        window.location.reload()
      }
    
    function clicktocart(){
        navigate(`/cart`)
    }
    function clicktohome(){
        navigate(`/home`)
    }
    function clicktoprofile(){
        navigate(`/profile`)
        setShowMenu(false)
    }


    return(
    <div className="container d-flex justify-content-between">
        <div className='header-row-left d-flex gap-5 justify-content-start align-items-center'>
            <div className="logo">
                <img onClick={clicktohome} src={logoimg} ></img>
            </div>
            <div className='Title-Markers' 
                 onMouseEnter={() => handleMouseEnter('markers')}
                 onMouseLeave={handleMouseLeave}>
                <span className='title' aria-expanded={openDropdown === 'markers' ? 'true' : 'false'}>
                    Markers
                </span>
                <i className="bi bi-arrow-down-short"></i>
                <div 
                    className={`dropdown-menu ${openDropdown === 'markers' ? 'show' : ''} Dropdown-Markers`}
                    onMouseEnter={() => handleMouseEnter('markers')}  
                    onMouseLeave={handleMouseLeave}  
                >
                    <div className='d-flex flex-column'>
                        <ul className='list-dropdown-marker d-flex flex-column gap-4 justify-content-center align-items-center' style={{ listStyleType: 'none', padding: 0, margin: 0 }}>
                            <a className='link-drop' href=''>Alcohol-Base Markers</a>
                            <a className='link-drop' href=''>Water-Base Markers</a>
                        </ul>
                    </div>
                </div>
            </div>
            <div className="Title-ArtPaints" 
                 onMouseEnter={() => handleMouseEnter('artPaints')}
                 onMouseLeave={handleMouseLeave}>
                <span className='title' aria-expanded={openDropdown === 'artPaints' ? 'true' : 'false'}>
                    Art and Paints
                </span>
                <i className="bi bi-arrow-down-short"></i>
                <div 
                    className={`dropdown-menu ${openDropdown === 'artPaints' ? 'show' : ''} Dropdown-ArtPaints`}
                    onMouseEnter={() => handleMouseEnter('artPaints')}  
                    onMouseLeave={handleMouseLeave}  
                >
                    <div className='d-flex flex-column'>
                        <ul className='list-dropdown-marker d-flex flex-column gap-4 justify-content-center align-items-center' style={{ listStyleType: 'none', padding: 0, margin: 0 }}>
                            <a className='link-drop' href=''>Acrylic Paints</a>
                            <a className='link-drop' href=''>Oil Paints</a>
                        </ul>
                    </div>
                </div>
            </div>
            <div className='Title-Hotsale'>
                <span className='title' onClick={handleclick}> Hot Selling
                </span>
            </div>
            <div className="Title-Support" 
                 onMouseEnter={() => handleMouseEnter('Support')}
                 onMouseLeave={handleMouseLeave}>
                <span className='title' aria-expanded={openDropdown === 'Support' ? 'true' : 'false'}>
                    Support
                </span>
                <i className="bi bi-arrow-down-short"></i>
                <div 
                    className={`dropdown-menu ${openDropdown === 'Support' ? 'show' : ''} Dropdown-Support`}
                    onMouseEnter={() => handleMouseEnter('Support')}  
                    onMouseLeave={handleMouseLeave}  
                >
                    <div className='d-flex flex-column'>
                        <ul className='list-dropdown-marker d-flex flex-column gap-4 justify-content-center align-items-center' style={{ listStyleType: 'none', padding: 0, margin: 0 }}>
                            <a className='link-drop' href=''>Facebook</a>
                            <a className='link-drop' href=''>Zalo</a>
                            <a className='link-drop' href=''>Instagram</a>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div className='header-row-right d-flex justify-content-end align-items-center gap-3'>
            <div className='search'>
                 <i className="bi bi-search"></i>
            </div>
            <div className="account-container">
                {/* Ảnh đại diện */}
                <div className="account-image" onClick={() => setShowMenu(!showMenu)}>
                    <img src={logo}  />
                </div>

                {/* Menu Logout */}
                {showMenu && (
                    <div className="dropdown-menu-logout d-flex flex-column gap-2">
                    <button onClick={clicktoprofile} className="logout-button">Profile</button>   
                    <button onClick={LogoutFeature} className="logout-button">Logout</button>
                </div>
                )}
            </div>
            <div className='shopping-cart' onClick={()=>clicktocart()}>
                <i className='cart bi bi-cart2'></i>
                <span className='shopping-cart-quantity'>{cartQuantity}</span>
                
            </div>
            
        </div>
    </div>

    )
}




export default Header