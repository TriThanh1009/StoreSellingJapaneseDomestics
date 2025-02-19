/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useState } from 'react';
import  './AdminHeaderComponent.css';
import logo from '../../../Image/chill.jpg'
const AdminHeaderComponent:React.FC = ()=>{
  const [showMenu, setShowMenu] = useState(false);

  function LogoutFeature(){
    localStorage.clear()
    window.location.reload()
  }
  return (
    <div className='admin-container'>
      <div className='admin-header d-flex flex-row justify-content-between align-items-center'>
        <div className='admin-header-left'>
          <div className='header-search'>
            <input className='header-search-input' placeholder='  Search for....'></input>
            {/* <i className="bi bi-search"></i> */}
          </div>
        </div>
        <div className='admin-header-right d-flex flex-row justify-content-center align-items-center gap-3'>
          <div> 
          <i className="bi bi-bell"></i>
          </div>
          <div>
            Thanh
          </div>
          <div className="account-container">
          {/* Ảnh đại diện */}
          <div className="account-image" onClick={() => setShowMenu(!showMenu)}>
            <img src={logo}  />
          </div>

          {/* Menu Logout */}
          {showMenu && (
            <div className="dropdown-menu-logout">
              <button onClick={() => LogoutFeature()} className="logout-button">Logout</button>
            </div>
      )}
    </div>
        </div>
      </div>
    </div>
  )
}

export default AdminHeaderComponent
