import { ReactNode, useEffect } from "react";
import { useNavigate } from "react-router-dom";

interface ProtectedRouteProps {
    children: ReactNode;
    roleRequired: string;
}

const ProtectedRoute: React.FC<ProtectedRouteProps> = ({ children, roleRequired }) => {
    const navigate = useNavigate(); // Sử dụng useNavigate()
    const userRole: string | null = localStorage.getItem("role");

    useEffect(() => {
        if (userRole !== roleRequired) {
            navigate("/home", { replace: true }); // Chuyển hướng nếu không đúng role
        }
    }, [userRole, roleRequired, navigate]);

    return {children}
};

export default ProtectedRoute;
