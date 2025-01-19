import React, { useEffect, useState } from "react"
import { PromotionModel } from "../../../Model/Promotion/PromotionModel"
import { getPromotion } from "../../../Responsitory/PromotionResponsitory"



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
                        <div className="card-header py-3">
                            <h6 className="m-0 font-weight-bold text-primary">Account Table</h6>
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