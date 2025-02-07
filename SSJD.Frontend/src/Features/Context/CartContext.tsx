/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { createContext, useState } from "react"

import { it } from "node:test"
import { ProductModel } from "../../Model/Product/ProductModel"


interface CardContextType{
    cart: ProductModel[]
    addtoCard:(product:ProductModel) => void
}

const CardContext = createContext<CardContextType | undefined>(undefined)

const CardProvider:React.FC<{children:React.ReactNode}> = ({children}) =>{
    const [cart,setCart] = useState<ProductModel[]>([])
    const addtoCard = (product:ProductModel)=>{
        const existingProduct = cart.find((item)=>item.id === product.id)
        if(existingProduct){
            setCart(
                cart.map((item)=> item.id ===product.id?{...item,quantity:item.quantity +1 } :item)
            )
        }else{
            setCart([...cart,{...product,quantity:1}])
        }
    }
    return(
        <CardContext.Provider value={{cart,addtoCard}}>
            {children}
        </CardContext.Provider>
    )
}
 





export default CardContext