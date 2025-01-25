import React, { useEffect, useState } from "react"
import { PromotionModel } from "../../../../Model/Promotion/PromotionModel"
import { getPromotion } from "../../../../Responsitory/PromotionResponsitory"
import clsx from 'clsx'
import AdminPromotionOptionsComponent from "../AdminPromotionOptionsComponent.tsx/AdminPromotionOptionsComponent"
import { deleteMemberCard } from "../../../../Responsitory/MemberCardResponsitory"


const AdminPromotionComponent:React.FC = () =>{
    const [promotions,setPromotions] = useState<PromotionModel[]>()
    const [showformoptions, setShowFormOptions] = useState(false);
    const [getid,setgetid] = useState('');
    let childpage
    useEffect(()=>{
        const fetch = async () =>{
            const data = await getPromotion()
            setPromotions(data)
        }
        fetch()
    },[])
    const clicktoshowFormoption = ()=>{
        setgetid('')
        setShowFormOptions(true)
    }
    const onCancel = ()=>{
        setShowFormOptions(false)
    }
    if(showformoptions){
        childpage = <AdminPromotionOptionsComponent selectedId={getid} onCancel={onCancel}/>
    } else childpage = <div></div>
    
    const handleEdit = (id:string)=>{
        setShowFormOptions(true)
        setgetid(id)
    }
    const onDelete = async (id: string) =>{
        await deleteMemberCard(id)
        window.location.reload()
    }
    return (
        <div>
                    <div className={clsx("card shadow","col-md-12",{"col-xl-9":showformoptions})}>
                        <div className="card-header py-3 d-flex flex-row justify-content-between">
                            <h6 className="m-0 font-weight-bold text-primary">Promotion Table</h6>
                            <button className="button-options" onClick={clicktoshowFormoption}>Create</button> 
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
                                        <i onClick={()=>handleEdit(promotion.id)} className="options-icon bi bi-pen"></i>
                                        <i onClick={()=>onDelete(promotion.id)} className="options-icon bi bi-x-octagon"></i>
                                        </td>
                                        </tr>
                                    ))}
                                        
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div className={clsx("child-page",{"col-md-3":showformoptions})}>
                                            {childpage}
                    </div>
                </div>

    )
}


export default AdminPromotionComponent