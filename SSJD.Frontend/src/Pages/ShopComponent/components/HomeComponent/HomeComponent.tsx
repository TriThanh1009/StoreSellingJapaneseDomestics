/* eslint-disable @typescript-eslint/no-unused-vars */
import React from 'react';
import { Outlet } from 'react-router-dom';
import ItemCard from '../../../ShareComponent/ItemCard/ItemCard';

const HomeComponent:React.FC = () =>{
  const itemslist = [
    { id: 1, name: "Item 1" },
    { id: 2, name: "Item 2" },
    { id: 3, name: "Item 3" },
    { id: 4, name: "Item 4" },
  ];
  return (
    <div>
      <div className="row g-2">
        {itemslist.map((itemslist)=>(
          <div className='col-3' key={itemslist.id}>
            <ItemCard/>
          </div>
        ))}
      </div>
      <Outlet/>
    </div>
    
  )
}



export default HomeComponent
