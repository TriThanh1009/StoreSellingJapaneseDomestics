/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useEffect, useState } from "react"
import { AccountModel } from "../../../../Model/Account/AccountModel"
import { getAccount } from "../../../../Responsitory/AccountResponsitory"
import './AdminAccountComponent.css'
import AdminAccountCreateComponent from "../AdminAccountCreateComponent/AdminAccountCreateComponent"

const AdminAccountComponent:React.FC = () =>{
    const [accounts,setAccounts] = useState<AccountModel[]>()
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
        childpage = <AdminAccountCreateComponent onCancel={onCancel}/>
    } else childpage = <div></div>
    

    useEffect(()=>{
        const fetchaccount = async () =>{
            const data = await getAccount()
            setAccounts(data)
        }
        fetchaccount()
    },[])
    
    return (
                <div>
                    <div className="card shadow mb-4">
                        <div className="card-header py-3 d-flex flex-row justify-content-between">
                            <h6 className="m-0 font-weight-bold text-primary">Account Table</h6>
                            <button className="button-options" onClick={clicktoshowFormoption} >Create</button> 
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr className="">
                                            <th>ID</th>
                                            <th>User Name</th>
                                            <th>Password</th>
                                            <th>Email</th>
                                            <th>options</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                    {Array.isArray(accounts) && accounts.map((account) => (
                                        <tr key={account.id}>
                                        <td>{account.id}</td>
                                        <td>{account.userName}</td>
                                        <td>{account.password}</td>
                                        <td>{account.email}</td>
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
                    
                    <div>
                        {childpage}
                    </div>
                </div>
                    

    )
}


export default AdminAccountComponent