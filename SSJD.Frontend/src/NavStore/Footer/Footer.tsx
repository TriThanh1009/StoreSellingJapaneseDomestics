import './Footer.css'
function Footer(){
    return(
        <div className="container d-flex flex-column justify-content-center align-items-center">
                <div className='d-flex flex-column justify-content-center align-items-center register-email gap-2'>
                    <span>
                    Bạn có thể gửi email đăng kí để có nhiều ưu đãi và dễ dàng được tư vấn
                    </span>
                    <div className='email-input'>
                        <input className='email' type='text' placeholder='Your Email'  />
                        <button className='sign-up-button'>Sign Up</button>
                    </div>
                    <span>
                        Chúng tôi luôn mang đến những sản phẩm chính hãng và tuyệt vời nhất đến từ Ohuhu
                    </span>
                    
                </div>
                <div className='information d-flex justify-content-center align-items-center gap-5'>
                    <div className='information-support'>
1
                    </div>
                    <div className='information-program'>
2
                    </div>
                    <div className='information-customer-care'>
3
                    </div>
                    <div className='about-me'>
4
                    </div>
                </div>
        </div>
    )
}


export default Footer