import React, { useEffect, useState } from "react"
import { MemberCardModel } from "../../../../Model/MemberCard/MemberCardModel"
import { getAccount } from "../../../../Responsitory/AccountResponsitory"


const AdminMemberCardComponent:React.FC = () =>{
    const [membercards,setMembercards] = useState<MemberCardModel[]>()

    useEffect(()=>{
        const fetchaccount = async () =>{
            const data = await getAccount()
            setMembercards(data)
        }
        fetchaccount()
    },[])
    return (
                    <div className="card shadow mb-4">
                        <div className="card-header py-3 d-flex flex-row justify-content-between">
                            <h6 className="m-0 font-weight-bold text-primary">Member Card Table</h6>
                            <button className="button-options">Create</button> 
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


export default AdminMemberCardComponent