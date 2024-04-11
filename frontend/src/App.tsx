import React, { useCallback } from 'react';
import MatladorList from './components/MatladorList';
import StatsTracker from './components/StatsTracker';
import Slide from './components/Slide';
import './App.css'
import { LoginButton } from './components/Login';
import { useAuth0 } from '@auth0/auth0-react';
import fridge from './assets/Fridge.png';


const App: React.FC = () => {
  const { isAuthenticated } = useAuth0();
  const refreshMatlador = useCallback(() => {
  }, []);

  return (
    <div className='app-container'>
      <div className="headerContainer">
        <h1 className='text-container'><em>Matlådor</em></h1>
        <LoginButton />
      </div>

      {isAuthenticated ? (
        <>
          <Slide />

          <MatladorList />
          <StatsTracker />
        </>
      ) : (
        <>
        <h3><strong>Matlåda (n.)</strong> [<em>matˈloːda</em>] <strong>Swedish</strong><br/>Swedish for lunch box</h3>
        <img src={fridge} alt="fridge" />
        </>
      )}
    </div>
  );
};

export default App;

