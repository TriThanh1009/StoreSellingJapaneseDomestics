import React, { useEffect, useState } from "react"
import { CategoryModel } from "../../../../Model/Category/CategoryModel"
import { getCategory } from "../../../../Responsitory/CategoryResponsitory"
import AdminCategoryCreateComponent from "../AdminCategoryCreateComponent/AdminCategoryCreateComponent"


const AdminCategoryComponent:React.FC = () =>{
    const[categorys,setcategorys] = useState<CategoryModel[]>()
    const [showformoptions, setShowFormOptions] = useState(false);
    let childpage
    const clicktoshowFormoption = ()=>{
        setShowFormOptions(true)
        console.log(showformoptions) 
    }
    const onCancel = ()=>{
        setShowFormOptions(false)
    }
    if(showformoptions){
        childpage = <AdminCategoryCreateComponent onCancel={onCancel} />
    } else childpage = <div></div>
    useEffect(()=>{
        const fetch = async () =>{
            const data = await getCategory()
            setcategorys(data)
        }
        fetch()
    })
    return (
        <div>

                    <div className="card shadow mb-4">
                        <div className="card-header py-3 d-flex flex-row justify-content-between">
                            <h6 className="m-0 font-weight-bold text-primary">Category Table</h6>
                            <button className="button-options" onClick={clicktoshowFormoption}>Create</button> 
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr className="text-center">
                                            <th>ID</th>
                                            <th>Name</th>
                                            <th>Options</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                        {Array.isArray(categorys) && categorys.map((category)=>(
                                            <tr>
                                                <td>{category.id}</td>
                                                <td>{category.name}</td>
                                                <td className="td-options d-flex flex-row gap-2">
                                                <i className="bi bi-pen"></i>
                                                <i className="bi bi-x-octagon"></i>
                                                </td>
                                                
                                            </tr>
                                        ))}
    
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    {childpage}
                </div>
    )
}


export default AdminCategoryComponent