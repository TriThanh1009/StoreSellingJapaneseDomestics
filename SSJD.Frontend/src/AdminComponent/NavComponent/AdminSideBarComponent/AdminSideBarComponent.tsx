import React, { useState } from "react"
import { Link } from "react-router-dom";
import './AdminSideBarComponent.css'

const AdminSideBarComponent:React.FC = ()=>{
  const [isOpen, setIsOpen] = useState(false);

  const toggleMenu = () => {
    setIsOpen(!isOpen);
  };
    return(
        <ul className="navbar-nav bg-gradient-primary sidebar sidebar-dark accordion" id="accordionSidebar">
      {/* Sidebar - Brand */}
      <a className="sidebar-brand d-flex align-items-center justify-content-center" href="index.html">
        <div className="sidebar-brand-icon rotate-n-15">
          <i className="fas fa-laugh-wink"></i>
        </div>
        <div className="sidebar-brand-text mx-3">SB Admin <sup>2</sup></div>
      </a>

      {/* Divider */}
      <hr className="sidebar-divider my-0" />

      {/* Nav Item - Dashboard */}
      <li className="nav-item active">
        <a className="nav-link" href="index.html">
          <i className="fas fa-fw fa-tachometer-alt"></i>
          <span>Dashboard</span>
        </a>
      </li>


      {/* Nav Item - Utilities Collapse Menu */}
      <li className="nav-item">
        <a className="nav-link collapsed" href="#" data-toggle="collapse" data-target="#collapseUtilities" aria-expanded="true" aria-controls="collapseUtilities">
          <i className="fas fa-fw fa-wrench"></i>
          <span>Utilities</span>
        </a>
        <div id="collapseUtilities" className="collapse" aria-labelledby="headingUtilities" data-parent="#accordionSidebar">
          <div className="bg-white py-2 collapse-inner rounded">
            <h6 className="collapse-header">Custom Utilities:</h6>
            <a className="collapse-item" href="utilities-color.html">Colors</a>
            <a className="collapse-item" href="utilities-border.html">Borders</a>
            <a className="collapse-item" href="utilities-animation.html">Animations</a>
            <a className="collapse-item" href="utilities-other.html">Other</a>
          </div>
        </div>
      </li>

      {/* Divider */}
      <hr className="sidebar-divider" />



      {/* Nav Item - Pages Collapse Menu */}
      <div
        className="d-flex justify-content-between align-items-center"
        onClick={toggleMenu}
        style={{ cursor: "pointer" }}
      >
        <h5 className="mb-0">Pages</h5>
        <i
          className={`bi bi-chevron-${isOpen ? "up" : "down"}`}
          style={{ fontSize: "1.2rem" }}
        ></i>
      </div>

      {/* Collapsible Menu */}
      {isOpen && (
        <div className="list-component d-flex flex-column gap-2">
          <Link to="/admin/account">Account</Link>
          <Link to="/admin/product">Product</Link>
          <Link to="/admin/category">Category</Link>
          <Link to="/admin/membercard">Member Card</Link>
          <Link to="/admin/Order">Order</Link>
          <Link to="/admin/promotion">Promotion</Link>
          <Link to="/admin/unitship">Unit Shipping</Link>
        </div>
      )}

    </ul>
    
    )
}


export default AdminSideBarComponent