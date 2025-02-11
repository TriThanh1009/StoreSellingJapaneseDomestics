/* eslint-disable @typescript-eslint/no-unused-vars */
/* eslint-disable @typescript-eslint/no-explicit-any */

import './Header.css'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap-icons/font/bootstrap-icons.css';
import logoimg from '../../../Image/logo.jpg'
import React, { useState } from 'react';
import { useShoppingCart } from '../../../Hooks/useShoppingCart';
import CartComponent from '../../../Pages/ShopComponent/components/CartComponent/CartComponent';

const Header:React.FC=()=>{
    const [openDropdown,setopenDropdown] = useState(null)
    const {cartQuantity} = useShoppingCart()
    const handleMouseEnter = (dropdownname:any) => {
        setopenDropdown(dropdownname);
    };
    const handleMouseLeave = () => {
        setopenDropdown(null);
    };
    const handleclick = (name:any)=>{
        window.location.href=name;
    }
    


    return(
    <div className="container d-flex justify-content-between">
        <div className='header-row-left d-flex gap-5 justify-content-start align-items-center'>
            <div className="logo">
                <img src={logoimg} ></img>
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
        <div className='header-row-right d-flex justify-content-end align-items-center gap-2'>
            <div className='search'>
                 <i className="bi bi-search"></i>
            </div>
            <div className='information'>
                <i className="bi bi-person-fill"></i>
            </div>
            <div className='shopping-cart'>
                <i className='cart bi bi-cart2'></i>
                <span className='shopping-cart-quantity'>{cartQuantity}</span>
                
            </div>
            
        </div>
    </div>

    )
}




export default Header