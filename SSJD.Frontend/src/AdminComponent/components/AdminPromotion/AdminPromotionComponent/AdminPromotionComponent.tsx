import React, { useEffect, useState } from "react"
import { PromotionModel } from "../../../../Model/Promotion/PromotionModel"
import { getPromotion } from "../../../../Responsitory/PromotionResponsitory"



const AdminPromotionComponent:React.FC = () =>{
    const [promotions,setPromotions] = useState<PromotionModel[]>()

    useEffect(()=>{
        const fetch = async () =>{
            const data = await getPromotion()
            setPromotions(data)
        }
        fetch()
    },[])
    return (
                    <div className="card shadow mb-4">
                        <div className="card-header py-3 d-flex flex-row justify-content-between">
                            <h6 className="m-0 font-weight-bold text-primary">Promotion Table</h6>
                            <button className="button-options">Create</button> 
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr className="">
                                            <th>ID</th>
                                            <th>Name</th>
                                            <th>Create Date</th>
                                            <th>End Date</th>
                                            <th>Percent Discount</th>
                                            <th>Options</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                    {Array.isArray(promotions) && promotions.map((promotion) => (
                                        <tr>
                                        <td>{promotion.id}</td>
                                        <td>{promotion.name}</td>
                                        <td>{promotion.createDate.toLocaleDateString()}</td>
                                        <td>{promotion.endDate.toLocaleDateString()}</td>
                                        <td>{promotion.percentDiscount}</td>
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

    )
}


export default AdminPromotionComponent