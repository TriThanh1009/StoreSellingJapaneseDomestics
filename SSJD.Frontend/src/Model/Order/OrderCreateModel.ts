export interface OrderCreateModel{
    userID? : string
    customerName? : string
    customerPhone? :string
    orderDate? : Date
    shippingUnitID? : "1"
    shippingDate? : Date
    shippingAddress? : string
    orderStatus? : string
    totalPrice? : number
    paymentMethod? : string
    paymentStatus? : string
}