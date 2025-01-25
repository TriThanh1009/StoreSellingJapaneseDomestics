import React, { useEffect, useState } from "react"

import { getAccount } from "../../../../Responsitory/AccountResponsitory"
import { MemberCardModel } from "../../../../Model/MemberCard/MemberCardModel"
import AdminMemberCardOptionsComponent from "../AdminMemberCardOptionsComponent/AdminMemberCardOptionsComponent"
import { deleteMemberCard } from "../../../../Responsitory/MemberCardResponsitory"
import clsx from 'clsx'

const AdminMemberCardComponent:React.FC = () =>{
    const [membercards,setMembercards] = useState<MemberCardModel[]>()
    const [showformoptions, setShowFormOptions] = useState(false);
    let childpage
    const [getid,setgetid] = useState('');
    useEffect(()=>{
        const fetchaccount = async () =>{
            const data = await getAccount()
            setMembercards(data)
        }
        fetchaccount()
    },[])
    const clicktoshowFormoption = ()=>{
        setgetid('')
        setShowFormOptions(true)
        console.log(showformoptions) 
    }
    const onCancel = ()=>{
        setShowFormOptions(false)
    }
    if(showformoptions){
        childpage = <AdminMemberCardOptionsComponent selectedID={getid} onCancel={onCancel} />
    } else childpage = <div></div>
    
    const handleEdit = (id:string)=>{
            setShowFormOptions(true)
            setgetid(id)
        }
    const onDelete = async (id:string)=>{
        await deleteMemberCard(id)
        window.location.reload()
        }
    return (
        <div>
                    <div className={clsx("card shadow","col-md-12",{"col-xl-9":showformoptions})}>
                        <div className="card-header py-3 d-flex flex-row justify-content-between">
                            <h6 className="m-0 font-weight-bold text-primary">Member Card Table</h6>
                            <button className="button-options" onClick={clicktoshowFormoption}>Create</button> 
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr className="">
                                            <th>ID</th>
                                            <th>Point</th>
                                            <th>Member Class</th>
                                            <th>Discount</th>
                                            <th>Options</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                    {Array.isArray(membercards) && membercards.map((membercard) => (
                                        <tr>
                                        <td>{membercard.id}</td>
                                        <td>{membercard.point}</td>
                                        <td>{membercard.memberClass}</td>
                                        <td>{membercard.discount}</td>
                                        <td className="td-options d-flex flex-row gap-2">
                                        <i onClick={()=>handleEdit(membercard.id)} className="options-icon bi bi-pen"></i>
                                        <i onClick={()=>onDelete(membercard.id)} className="options-icon bi bi-x-octagon"></i>
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


export default AdminMemberCardComponent