import React, { useEffect, useState } from "react"
import { CategoryModel } from "../../../../Model/Category/CategoryModel"
import { getCategory } from "../../../../Responsitory/CategoryResponsitory"


const AdminCategoryComponent:React.FC = () =>{
    const[categorys,setcategorys] = useState<CategoryModel[]>()

    useEffect(()=>{
        const fetch = async () =>{
            const data = await getCategory()
            setcategorys(data)
        }
        fetch()
    })
    return (
                    <div className="card shadow mb-4">
                        <div className="card-header py-3">
                            <h6 className="m-0 font-weight-bold text-primary">Category Table</h6>
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr className="text-center">
                                            <th>ID</th>
                                            <th>Name</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                        {Array.isArray(categorys) && categorys.map((category)=>(
                                            <tr>
                                                <td>{category.id}</td>
                                                <td>{category.name}</td>
                                            </tr>
                                        ))}
    
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

    )
}


export default AdminCategoryComponent