import { BrowserRouter, Route, Routes } from "react-router-dom"
import AdminLayoutComponent from "./AdminComponent/NavComponent/AdminLayoutComponent/AdminLayoutComponent"
import routes from './AdminComponent/NavComponent/AdminRoutes'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap-icons/font/bootstrap-icons.css';

const AppAdmin:React.FC=()=>{
    return (
      <BrowserRouter>
      <Routes>
        {routes.map((route, index) => (
          <Route
            key={index}
            path={route.path}
            element={<AdminLayoutComponent>{route.element}</AdminLayoutComponent>}
          >
            {route.children?.map((child, childIndex) => (
              <Route
                key={childIndex}
                path={child.path}
                element={child.element}
              />
            ))}
          </Route>
        ))}
      </Routes>
    </BrowserRouter>
    )
  }


export default AppAdmin