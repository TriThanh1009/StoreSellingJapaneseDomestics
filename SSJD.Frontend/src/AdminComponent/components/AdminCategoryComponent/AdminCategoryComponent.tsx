import React from "react"


const AdminCategoryComponent:React.FC = () =>{
    return (
                    <div className="card shadow mb-4">
                        <div className="card-header py-3">
                            <h6 className="m-0 font-weight-bold text-primary">Account Table</h6>
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr className="text-center">
                                            <th>User Name</th>
                                            <th>Password</th>
                                            <th>Email</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                        <tr>
                                            
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

    )
}


export default AdminCategoryComponent