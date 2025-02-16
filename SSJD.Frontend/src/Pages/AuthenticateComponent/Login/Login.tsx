/* eslint-disable @typescript-eslint/no-unused-vars */
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap-icons/font/bootstrap-icons.css';
import './Login.css'
import { useEffect, useState } from 'react';
import { LoginAccess } from '../../../Responsitories/LoginRespository';
import { LoginModel } from '../../../Model/Login/LoginModel';
import { useNavigate } from 'react-router-dom';

function Login(){
    const [account,setaccount] = useState<LoginModel>() 
    const navigate = useNavigate()
    const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        const { name, value } = e.target;
        setaccount((prev) => ({
            ...prev,
            [name]: value,
        }));
        
    };
    useEffect(() => {
        const storedRole = localStorage.getItem("role");
        if (storedRole) {
            if (storedRole === "Admin") {
                navigate("/admin");
            } else if(storedRole === "Customer")  {
                navigate("/home");
            }
        }
    }, [])


    const handleSubmit = async (e:React.FormEvent)=>{
        e.preventDefault()
        await LoginAccess(account)
        window.location.reload()
    }

    function navtoRegister(){
        navigate(`/register`)
    }

    function navtoForgotpassword(){
        navigate(`/forgot`)
    }


     return(
        <div className='container'>
            <div className='login d-flex flex-column justify-content-center align-items-center'>
                <div className='title'>
                    <span>Login</span>
                </div>
                <form onSubmit={handleSubmit}>
                    <div className='login-input'>
                        <div className='input-information d-flex flex-column justify-content-center gap-3'>
                            <span>Tài khoản</span>
                            <input type='text' name='username' onChange={handleChange} placeholder='Your Email'></input>
                            <span>Mật khẩu</span>
                            <input type='password' name='password' onChange={handleChange}></input>
                            <button className='button-signin'>Sign In</button>
                        </div>
                    </div>
                </form>
                <div className='register-forgotpassword d-flex flex-row gap-3'>
                    <span className='register-forgotpassword-items' onClick={navtoForgotpassword}>Forgot your password ?</span>
                    <span>/</span>
                    <span className='register-forgotpassword-items' onClick={navtoRegister}>Register Account</span>
                </div>
            </div>
        </div>
    )
}

export default Login
