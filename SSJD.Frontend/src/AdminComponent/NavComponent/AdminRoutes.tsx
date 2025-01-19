import AdminAccountComponent from "../components/AdminAccount/AdminAccountComponent/AdminAccountComponent";
import AdminCategoryComponent from "../components/AdminCategory/AdminCategoryComponent/AdminCategoryComponent";
import AdminProductComponent from "../components/AdminProduct/AdminProductComponent/AdminProductComponent";




interface RouteConfig{
    path:string;
    element: React.ReactNode;
    children?:RouteConfig[];
}

const routes: RouteConfig[]=[
    {path: '/admin/product',element:<AdminProductComponent/>,
        children:[
            //{}
        ]

    },
    {path: '/admin/account',element:<AdminAccountComponent/>},
    {path: '/admin/category',element:<AdminCategoryComponent/>},

]
export default routes