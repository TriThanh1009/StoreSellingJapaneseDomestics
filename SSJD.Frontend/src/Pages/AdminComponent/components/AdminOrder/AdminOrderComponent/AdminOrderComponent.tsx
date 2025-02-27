/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useEffect, useState } from "react"
import { OrderModel } from "../../../../../Model/Order/OrderModel"
import { ChangePaymentStatus, getOrder, getOrderByID } from "../../../../../Responsitories/OrderResponsitory"
import  './AdminOrderComponent.css'
import switchoff from "../../../../../Image/switch-off.png"
import switchon from "../../../../../Image/switch-on.png"

const AdminOrderComponent:React.FC = () =>{
    const [orders,setorders] = useState<OrderModel[]>()
    const [status, setStatus] = useState(0);
    useEffect(()=>{
        fetch()
    },[])
    const fetch = async () =>{
        const data = await getOrder()
        setorders(data)
    }

        const changepaymentstatus = () =>{     
            orders?.map(async (item)=>{
                await ChangePaymentStatus(item.id)
                const updatepayment = await getOrderByID(item.id)
                setStatus(updatepayment.paymentStatus)
                console.log(status)
            })
        }
    
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
                                        <td>{order.orderStatus==="1" ? "Thành công" : "Thất bại"} </td>
                                        <td>{order.totalPrice}</td>
                                        <td>{order.paymentMethod}</td>
                                        <td><img className="switch-options" src={status === 1 ? switchoff : switchon} //Vì mặc định stastua  useState(0); nên cái này nó phải ngược, khi nào tìm được cách sẽ fix
                                                                            onClick={changepaymentstatus} 
                                                                            style={{ cursor: "pointer" }}/>
                                        </td> 
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