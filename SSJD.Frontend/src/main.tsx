/* eslint-disable @typescript-eslint/no-unused-vars */

import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import AppAdmin from './AppAdmin.tsx'

createRoot(document.getElementById('root')!).render(
  <StrictMode>  
    <App />
  </StrictMode>,
)
