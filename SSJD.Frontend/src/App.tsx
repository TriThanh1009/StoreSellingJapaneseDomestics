/* eslint-disable @typescript-eslint/no-unused-vars */

import './App.css'
import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import routes from './NavStore/Routes/routes';
import Layout from './NavStore/Layout/Layout';

const App:React.FC=()=>{
  return (
    <Router>
      <Routes>
        {routes.map((route,index)=>(
          <Route key={index} path={route.path} element={<Layout>{route.element}</Layout>}></Route>
        ))}
      </Routes>
    </Router>
  )
}

export default App
