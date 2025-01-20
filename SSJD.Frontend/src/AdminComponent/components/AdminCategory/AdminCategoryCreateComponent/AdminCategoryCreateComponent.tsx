
/* eslint-disable @typescript-eslint/no-unused-vars */
import React from 'react';

interface Props {
    onCancel: () => void; // Định nghĩa prop onCancel
  }
const AdminCategoryCreateComponent:React.FC<Props> = ({onCancel})=>{
    
    return(
    <form className="form" >
        <div className="form-group row">
            <div className="col-sm-10">
            <label className="col-sm-5 col-form-label"> ID </label>
            <input type="text" id="id"   className="form-control" /> 
            </div>
        </div>
        <div className="form-group row">
            <label className="col-sm-5 col-form-label">Name</label>
            <div className="col-sm-10">
                <input type="text" id="name"  name="name"   pattern="[a-zA-Z ]+"   className="form-control" />
            </div>
        </div>
        <div className="form-group row">
            <label className="col-sm-5 col-form-label">Money</label>
            <div className="col-sm-10">
                <input type="text" id="money"   name="money"  className="form-control" />

            </div>
        </div>
        <div className='button-options-list d-flex flex-row gap-3' >
            <button className="button-options">Accept</button> 
            <button className="button-options" onClick={onCancel} >Cancel</button> 
        </div>
        
</form>
    )
}






export default AdminCategoryCreateComponent