/* eslint-disable @typescript-eslint/no-unused-vars */
import React from "react"



const AdminProductDetailOptionsComponent:React.FC = ()=>{
    return(
        <div>
        <div className="form-group row" >
                    <label className="col-sm-5 col-form-label">Description</label>
                    <div className="col-sm-10">
                    <input type="text" id="description"  name="description"   className="form-control" />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Warranty</label>
                    <div className="col-sm-10">
                        <input type="text" id="warranty"  name="warranty"     pattern="[a-zA-Z ]+"   className="form-control" />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Origin</label>
                    <div className="col-sm-10">
                        <input type="text" id="origin"   name="origin" className="form-control" />

                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">More Image</label>
                    <div className="col-sm-10">
                        <input type="text" id="additionalImage"   name="additionalImage"    className="form-control" />

                    </div>
                </div>
            </div>
    )
}


export default AdminProductDetailOptionsComponent