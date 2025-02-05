/* eslint-disable @typescript-eslint/no-unused-vars */
import React from 'react';
import ItemCard from '../../ShareComponent/ItemCard/ItemCard';

const HomeComponent:React.FC = () =>{
  const itemslist = [
    { id: 1, name: "Item 1" },
    { id: 2, name: "Item 2" },
    { id: 3, name: "Item 3" },
    { id: 4, name: "Item 4" },
    { id: 5, name: "Item 5" },
    { id: 6, name: "Item 6" },
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
    </div>
    
  )
}



export default HomeComponent
