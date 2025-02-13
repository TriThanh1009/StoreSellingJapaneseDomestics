import { useParams } from "react-router-dom";
import momopayment from '../../../../Image/momo_payment.jpg'
import vcbpayment from '../../../../Image/vcb_payment.jpg'
import './PaymentComponent.css'

const PaymentComponent = () => {
    const { method } = useParams(); // Lấy giá trị method từ URL

    console.log(method); // Kiểm tra xem method có nhận đúng giá trị không

    return (
        <div className='payment-container d-flex justify-content-center gap-5'>
            <div className="payment-logo d-flex justify-content-center align-items-center">
                {method === "momo" && <img src={momopayment} alt="momopayment" />}
                {method === "vcb" && <img src={vcbpayment} alt="vcbpayment" />}
            </div>
            <div className="d-flex flex-column gap-2">
                 
            </div>


        </div>
    );
};

export default PaymentComponent;
