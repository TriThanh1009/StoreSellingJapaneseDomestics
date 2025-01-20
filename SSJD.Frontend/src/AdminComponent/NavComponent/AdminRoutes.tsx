import AdminAccountComponent from "../components/AdminAccount/AdminAccountComponent/AdminAccountComponent";
import AdminCategoryComponent from "../components/AdminCategory/AdminCategoryComponent/AdminCategoryComponent";
import AdminMemberCardComponent from "../components/AdminMemberCard/AdminMemberCardComponent/AdminMemberCardComponent";
import AdminOrderComponent from "../components/AdminOrder/AdminOrderComponent/AdminOrderComponent";
import AdminOrderCreateComponent from "../components/AdminOrder/AdminOrderCreateComponent/AdminOrderCreateComponent";
import AdminProductComponent from "../components/AdminProduct/AdminProductComponent/AdminProductComponent";
import AdminPromotionComponent from "../components/AdminPromotion/AdminPromotionComponent/AdminPromotionComponent";
import AdminUnitShipComponent from "../components/AdminUnitShip/AdminUnitShipComponent/AdminUnitShipComponent";



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
        children: [
          {
            path: 'create',
            element: <AdminOrderCreateComponent />,
          },
        ],
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