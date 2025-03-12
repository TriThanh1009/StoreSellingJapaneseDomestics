import React, { useState } from "react";
import "./forgotpassword.css"
import { useNavigate } from "react-router-dom";
const Forgotpassword:React.FC=()=>{
    const navigate = useNavigate()
    const [email,setEmail] = useState("")
    function navtoLogin(){
        navigate(`/Login`)
    }

    const handlesubmit = async (e:React.FormEvent)=>{
        e.preventDefault();

    //   await sendPasswordResetEmail(auth, email, {
    //     url: "http://localhost:5255/reset-password", // URL redirect sau khi nhấp link trong email
    //   });
    }
    return(
        <div className='container'>
            <div className='forgot d-flex flex-column justify-content-center align-items-center'>
                <div className='d-flex flex-column justify-content-center align-items-center'>
                    <span className='title-reset'> Reset your Password</span>
                    <span>We will sent you an email to reset your password</span>
                </div>
                <form className='forgot-input'>
                    <div className='forgot-information d-flex flex-column justify-content-center gap-3'>
                        <span>Email</span>
                        <input
                                type="email"
                                value={email}
                                onChange={(e) => setEmail(e.target.value)}
                                placeholder="Nhập email của bạn"
                                required
        />
                        <button onClick={handlesubmit} className='button-signin'>Submit</button>
                    </div>
                    <div className="forgot-cancel">
                        <span className="forgot-cancel-item" onClick={navtoLogin}>Cancel</span>
                    </div>
                </form>
            </div>

        </div>
    )
}



export default Forgotpassword;