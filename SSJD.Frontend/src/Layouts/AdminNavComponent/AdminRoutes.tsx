import AdminAccountComponent from "../../Pages/AdminComponent/components/AdminAccount/AdminAccountComponent/AdminAccountComponent";
import AdminCategoryComponent from "../../Pages/AdminComponent/components/AdminCategory/AdminCategoryComponent/AdminCategoryComponent";
import AdminMemberCardComponent from "../../Pages/AdminComponent/components/AdminMemberCard/AdminMemberCardComponent/AdminMemberCardComponent";
import AdminOrderComponent from "../../Pages/AdminComponent/components/AdminOrder/AdminOrderComponent/AdminOrderComponent";
import AdminProductComponent from "../../Pages/AdminComponent/components/AdminProduct/AdminProductComponent/AdminProductComponent";
import AdminPromotionComponent from "../../Pages/AdminComponent/components/AdminPromotion/AdminPromotionComponent/AdminPromotionComponent";
import AdminUnitShipComponent from "../../Pages/AdminComponent/components/AdminUnitShip/AdminUnitShipComponent/AdminUnitShipComponent";




interface RouteConfig{
    path:string;
    element: React.ReactNode;
    children?:RouteConfig[];
}

const routes: RouteConfig[]=[
    {
        path: '/admin/product',
        element: <AdminProductComponent />,
        // children: [
        //   {
        //     path: 'create', // Không cần thêm dấu `/`
        //     element: <AdminProductCreateComponent />,
        //   },
        // ],
      },
      {
        path: '/admin/account',
        element: <AdminAccountComponent />,
      },
      {
        path: '/admin/category',
        element: <AdminCategoryComponent />,
      },
      {
        path: '/admin/membercard',
        element: <AdminMemberCardComponent />,
      },
      {
        path: '/admin/order',
        element: <AdminOrderComponent />,
      },
      {
        path: '/admin/promotion',
        element: <AdminPromotionComponent />,
      },
      {
        path: '/admin/unitship',
        element: <AdminUnitShipComponent />,
      },
      
      
     
      

]
export default routes