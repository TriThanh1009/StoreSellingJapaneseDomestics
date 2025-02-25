import React, { useEffect, useState } from "react"
import { OrderModel } from "../../../../../Model/Order/OrderModel"
import { getOrder } from "../../../../../Responsitories/OrderResponsitory"



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
                        <div className="card-header py-3 d-flex flex-row justify-content-between">
                            <h6 className="m-0 font-weight-bold text-primary">Order Table</h6>
                            <button className="button-options">Create</button> 
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr className="">
                                            <th>Customer</th>
                                            <th>Phone Number</th>
                                            <th>Order Date</th>
                                            <th>Shipping Unit</th>
                                            <th>ShippingAddress</th>
                                            <th>OrderStatus</th>
                                            <th>Total Price</th>
                                            <th>Payment Method</th>
                                            <th>Payment Status</th>
                                            <th>Options</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                    {Array.isArray(orders) && orders.map((order) => (
                                        <tr>
                                        <td>{order.customerName}</td>
                                        <td>{order.customerPhone}</td>
                                        <td>{order.orderDate.toString().split("T")[0]}</td>
                                        <td>{order.shippingUnit}</td>
                                        <td>{order.shippingAddress}</td>
                                        <td>{order.orderStatus}</td>
                                        <td>{order.totalPrice}</td>
                                        <td>{order.paymentMethod}</td>
                                        <td>{order.paymentStatus}</td>
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


export default AdminOrderComponent