import React, { useCallback } from 'react';
import MatladorList from './components/MatladorList';
import StatsTracker from './components/StatsTracker';
import Slide from './components/Slide';
import './App.css'

const App: React.FC = () => {
  const refreshMatlador = useCallback(() => {
  }, []);

  return (
    <body>
     

      <div className='app-container'>
        <div className="headerContainer">
          <Slide />
          <h1 className='text-container'><em>Matlådor</em></h1>
        </div>

        <MatladorList />
        <StatsTracker />

      </div>
    </body>



  );
};

export default App;
