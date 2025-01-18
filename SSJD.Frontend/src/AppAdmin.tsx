import { BrowserRouter, Route, Routes } from "react-router-dom"
import AdminLayoutComponent from "./AdminComponent/NavComponent/AdminLayoutComponent/AdminLayoutComponent"
import routes from './AdminComponent/NavComponent/AdminRoutes'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap-icons/font/bootstrap-icons.css';

const AppAdmin:React.FC=()=>{
    return (
      <BrowserRouter>
        <Routes>
          {routes.map((route,index)=>(
            <Route key={index} path={route.path} element={<AdminLayoutComponent>{route.element}</AdminLayoutComponent>}></Route>
          ))}
        </Routes>
      </BrowserRouter>
    )
  }


export default AppAdmin