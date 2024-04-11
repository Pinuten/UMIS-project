// Part of src/App.tsx or another component
import React, { useCallback } from 'react';
import MatladorList from './components/MatladorList';
import Add from './components/Add';

const App: React.FC = () => {
  const refreshMatlador = useCallback(() => {
  }, []);

  return (
    <div>
      <Add/>
      <h1>Matlådor</h1>
      <MatladorList />
    </div>
  );
};

export default App;