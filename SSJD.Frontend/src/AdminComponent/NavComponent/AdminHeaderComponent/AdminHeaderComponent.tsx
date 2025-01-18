/* eslint-disable @typescript-eslint/no-unused-vars */
import React from 'react';
import  './AdminHeaderComponent.css';

const AdminHeaderComponent:React.FC = ()=>{
  return (
    <div className='admin-container'>
      <div className='admin-header d-flex flex-row justify-content-between'>
        <div className='admin-header-left'>
          <div className='header-search'>
            <input className='header-search-input' placeholder='Search for....'></input>
            <i className="bi bi-search"></i>
          </div>
        </div>
        <div className='admin-header-right d-flex flex-row justify-content-center align-items-center gap-3'>
          <div>
          <i className="bi bi-bell"></i>
          </div>
          <div>
            Thanh
          </div>
          <div className='account-image'>
          </div>
        </div>
      </div>
    </div>
  )
}

export default AdminHeaderComponent
