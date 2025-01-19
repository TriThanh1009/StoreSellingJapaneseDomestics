import React, { useEffect, useState } from "react"
import { getAccount } from "../../../Responsitory/AccountResponsitory"
import { MemberCardModel } from "../../../Model/MemberCard/MemberCardModel"


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
                        <div className="card-header py-3">
                            <h6 className="m-0 font-weight-bold text-primary">Member Card Table</h6>
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
                                        </tr>
                                    </thead>

                                    <tbody>
                                    {Array.isArray(membercards) && membercards.map((membercard) => (
                                        <tr key={membercard.id}>
                                        <td>{membercard.id}</td>
                                        <td>{membercard.point}</td>
                                        <td>{membercard.memberClass}</td>
                                        <td>{membercard.discount}</td>
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