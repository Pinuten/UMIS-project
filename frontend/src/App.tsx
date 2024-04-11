import React, { useCallback } from 'react';
import MatladorList from './components/MatladorList';
import StatsTracker from './components/StatsTracker';
import Slide from './components/Slide';
import './App.css'

const App: React.FC = () => {
  const refreshMatlador = useCallback(() => {
  }, []);

  return (
    <div className='app-container'>
      <div className="headerContainer">
        <Slide /> 
        <h1><em>Matlådor</em></h1> 
        <StatsTracker /> 
      </div>
      
      <MatladorList />
    </div>
  );
};

export default App;
