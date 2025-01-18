import AdminAccountComponent from "../components/AdminAccountComponent/AdminAccountComponent";
import AdminProductComponent from "../components/AdminProductComponent/AdminProductComponent";




interface RouteConfig{
    path:string;
    element: React.ReactNode;
}

const routes: RouteConfig[]=[
    {path: '/admin/product',element:<AdminProductComponent/>},
    {path: '/admin/account',element:<AdminAccountComponent/>},

]
export default routes