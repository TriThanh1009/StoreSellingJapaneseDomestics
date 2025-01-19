import React, { useEffect, useState } from "react"
import { OrderModel } from "../../../Model/Order/OrderModel"
import { getOrder } from "../../../Responsitory/OrderResponsitory"


const AdminOrderComponent:React.FC = () =>{
    const [orders,setorders] = useState<OrderModel[]>()

    useEffect(()=>{
        const fetch = async () =>{
            const data = await getOrder()
            setorders(data)
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
                                            <th>User Name</th>
                                            <th>Password</th>
                                            <th>Email</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                    {Array.isArray(orders) && orders.map((orders) => (
                                        <tr>
                                        <td>{orders.id}</td>
                                        <td>{orders.customerID}</td>
                                        <td>{orders.orderDate.toLocaleDateString()}</td>
                                        <td>{orders.shippingUnitID}</td>
                                        <td>{orders.shippingDate.toLocaleDateString()}</td>
                                        <td>{orders.shippingAddress}</td>
                                        <td>{orders.orderStatus}</td>
                                        <td>{orders.totalPrice}</td>
                                        <td>{orders.paymentMethod}</td>
                                        <td>{orders.paymentStatus}</td>


                                        </tr>
                                    ))}
                                        
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

    )
}


export default AdminOrderComponent