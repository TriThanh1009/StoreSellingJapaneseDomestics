import React from "react";
import './Register.css'
const Register:React.FC=()=>{
    return(
        <div className='container'>
            <div className='register d-flex flex-column justify-content-center align-items-center'>
                <div className='register-title'>
                    <span>Create Account</span>
                </div>
                <div className='register-input'>
                    <div className='input-information d-flex flex-column justify-content-center gap-3'>
                        <span>Full Name</span>
                        <input type='text'></input>
                        <span>Email</span>
                        <input type='text' placeholder='Your Email'></input>
                        <span>Password</span>
                        <input type='password'></input>
                        <button className='button-signin'>Create</button>
                    </div>
                </div>
                <div className='register-forgotpassword d-flex flex-row gap-3'>
                    <span className='register-forgotpassword-items'>Already have an account</span>
                </div>
            </div>

        </div>
    )
}



export default Register