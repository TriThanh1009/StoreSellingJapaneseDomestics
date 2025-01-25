/* eslint-disable @typescript-eslint/no-unused-vars */
import './AdminProductOptionsComponent.css'
interface Props {
    onCancel: () => void; // Định nghĩa prop onCancels
  }

const AdminProductOptionsComponent:React.FC<Props> = ({onCancel}) =>{
    return (
        <form className="form" >
            <h1 className='text-center'>Create</h1>
        <div className='d-flex flex-row'>
            <div>
                <div className="form-group row" >
                    <label className="col-sm-5 col-form-label">ID</label>
                    <div className="col-sm-10">
                    <input type="text" id="id"  name="id"   className="form-control" />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Name</label>
                    <div className="col-sm-10">
                        <input type="text" id="name"  name="name"     pattern="[a-zA-Z ]+"   className="form-control" />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Brand</label>
                    <div className="col-sm-10">
                        <input type="text" id="brand"   name="brand" className="form-control" />

                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Category</label>
                    <div className="col-sm-10">
                        <input type="text" id="categoryID"   name="categoryID"    className="form-control" />

                    </div>
                </div>
            </div>
            <div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Price</label>
                    <div className="col-sm-10">
                        <input type="text" id="price"   name="price"    className="form-control" />

                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Stock</label>
                    <div className="col-sm-10">
                        <input type="text" id="stock"   name="stock"    className="form-control" />

                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Active</label>
                    <div className="col-sm-10">
                        <input type="text" id="isActive"   name="isActive"    className="form-control" />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="col-sm-5 col-form-label">Image</label>
                    <div className="col-sm-10">
                        <input type="text" id="image"   name="image"    className="form-control" />
                    </div>
                </div>
                <div className='button-options-list d-flex flex-row gap-3' >
                    <button type='submit' className="button-options">Accept</button>
                    <button className="button-options" onClick={onCancel} >Cancel</button> 
                </div>
            </div>
           
        </div>
    </form>
    )
}



export default AdminProductOptionsComponent