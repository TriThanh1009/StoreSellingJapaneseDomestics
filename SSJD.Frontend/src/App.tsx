/* eslint-disable @typescript-eslint/no-unused-vars */

import './App.css'
import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Layout from './ShopComponent/NavStore/Layout/Layout';
import routes from './ShopComponent/NavStore/routes';



const App:React.FC=()=>{
  return (
    <Router>
      <Routes>
        {routes.map((route,index)=>(
          <Route key={index} path={route.path} element={<Layout>{route.element}</Layout>}>
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
    </Router>
  )
}

export default App
