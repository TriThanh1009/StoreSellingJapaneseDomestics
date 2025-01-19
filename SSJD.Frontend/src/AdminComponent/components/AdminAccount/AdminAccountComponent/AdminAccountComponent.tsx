import React, { useEffect, useState } from "react"
import { AccountModel } from "../../../../Model/Account/AccountModel"
import { getAccount } from "../../../../Responsitory/AccountResponsitory"


const AdminAccountComponent:React.FC = () =>{
    const [accounts,setAccounts] = useState<AccountModel[]>()

    useEffect(()=>{
        const fetchaccount = async () =>{
            const data = await getAccount()
            setAccounts(data)
        }
        fetchaccount()
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
                                            <th>User Name</th>
                                            <th>Password</th>
                                            <th>Email</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                    {Array.isArray(accounts) && accounts.map((account) => (
                                        <tr key={account.id}>
                                        <td>{account.id}</td>
                                        <td>{account.userName}</td>
                                        <td>{account.password}</td>
                                        <td>{account.email}</td>
                                        </tr>
                                    ))}
                                        
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

    )
}


export default AdminAccountComponent