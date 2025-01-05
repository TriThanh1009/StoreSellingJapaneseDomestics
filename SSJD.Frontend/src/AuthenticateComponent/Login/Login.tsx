import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap-icons/font/bootstrap-icons.css';
import './Login.css'
function Login(){
    return(
        <div className='container'>
            <div className='login d-flex flex-column justify-content-center align-items-center'>
                <div className='login-title'>
                    <span>Login</span>
                </div>
                <div className='login-input'>
                    <div className='input-information d-flex flex-column justify-content-center gap-3'>
                        <span>Email</span>
                        <input type='text' placeholder='Your Email'></input>
                        <span>Password</span>
                        <input type='password'></input>
                        <button className='button-signin'>Sign In</button>
                    </div>
                </div>
                <div className='register-forgotpassword d-flex flex-row gap-3'>
                    <span className='register-forgotpassword-items'>Forgot your password ?</span>
                    <span>/</span>
                    <span className='register-forgotpassword-items'>Register Account</span>
                </div>
            </div>
        </div>
    )
}

export default Login