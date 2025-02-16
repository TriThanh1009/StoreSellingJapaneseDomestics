/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useState } from "react";
import './Register.css'
import { useNavigate } from "react-router-dom";
import { AccountCreateModel } from "../../../Model/Account/AccountCreateModel";
import { createAccount } from "../../../Responsitories/AccountResponsitory";
import { UserCreateModel } from "../../../Model/User/UserCreateModel";
import { createUser } from "../../../Responsitories/UserResponsitory";
const Register:React.FC=()=>{
    const navigate = useNavigate()
    const [register,setregister] = useState<AccountCreateModel>()
    const [user,setuser] = useState<UserCreateModel>({
        email : "" ,
        phoneNumber : "" ,
        sex : 0,
        address : "" ,
        identityCard : "" ,
        accountID: "" ,
        memberCardID: "3",
        image: "" ,
    })
    const handleChangeAccount = (e: React.ChangeEvent<HTMLInputElement>) => {
            const { name, value } = e.target;
            console.log(value)
            setregister((prev) => ({
                ...prev,
                [name]: value,
            }));
            
        };
    const handleChangeUser = (e: React.ChangeEvent<HTMLInputElement>) => {
            const { name, value } = e.target;
            console.log(value)
            setuser((prev) => ({
                ...prev,
                [name]: value,
            }));
            
        };
    const handleSubmit = async () => {
        if(user){
            const accountdata = await createAccount(register)
            setTimeout(async () => {
                user.accountID = accountdata
                await createUser(user)
            },100);

        }   
        };
    
    function navtoLogin(){
        navigate(`/login`)
    }
    return(
        <div className='container'>
            <div className='register d-flex flex-column justify-content-center align-items-center'>
                <div className='register-title'>
                    <span>Create Account</span>
                </div>
                <form onSubmit={handleSubmit}>
                <div className='register-input'>
                    <div className='input-information d-flex flex-column justify-content-center gap-3'>
                        <span>Full Name</span>
                        <input type='text' name="userName" onChange={handleChangeUser}></input>
                        <span>User Name</span>
                        <input type='text' name="userName" onChange={handleChangeAccount}></input>
                        <span>Password</span>
                        <input type='password' name="password" onChange={handleChangeAccount}></input>
                        <span>Repeat Password</span>
                        <input type='password' name="repeatpassword" onChange={handleChangeAccount}></input>
                        <span>Email</span>
                        <input type='text' placeholder='Your Email' name="email" onChange={handleChangeAccount}></input>
                        <button className='button-signin'>Create</button>
                    </div>
                </div>
                </form>
                <div className='register-forgotpassword d-flex flex-row gap-3'>
                    <span onClick={handleSubmit} className='register-forgotpassword-items'>Already have an account</span>
                </div>
            </div>

        </div>
    )
}



export default Register
