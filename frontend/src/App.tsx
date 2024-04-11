import React, { useCallback } from 'react';
import MatladorList from './components/MatladorList';
import './App.css';
import StatsTracker from './components/StatsTracker';
import Slide from './components/Slide';

const App: React.FC = () => {
  const refreshMatlador = useCallback(() => {
  }, []);

  return (
    <div className='appContainer'>
      <div className="headerContainer">
        <Slide />
        <h1>Matlådor</h1>
        <StatsTracker/>
      </div>
      
      <MatladorList />
    </div>
  );
};

export default App;
