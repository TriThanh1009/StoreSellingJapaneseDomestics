export interface OrderModel{
    id : string
    customerID : string
    orderDate : Date
    shippingUnitID : string
    shippingDate : Date
    shippingAddress : string
    orderStatus : string
    totalPrice : number
    paymentMethod : string
    paymentStatus : string
}