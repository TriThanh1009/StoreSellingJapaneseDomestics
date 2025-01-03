

import './App.css'
import Footer from './NavStore/Footer/Footer'
import Header from './NavStore/Header/Header'

function App() {


  return (
    <div className='d-flex flex-column min-vh-100'>
      <div>
        <Header/>
      </div>        
      <div className='flex-grow-1 p-4'>

      </div>
      <div className='footer'>
        <Footer/>
      </div>
        
    </div>
  )
}

export default App
