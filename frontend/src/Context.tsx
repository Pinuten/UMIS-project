import React, { createContext, useState, ReactNode } from 'react';

interface Matlada {
  id?: number;
  guid?: string;
  size: 'Normal' | 'Small';
  createdAt?: string;
  name: string;
}

interface ContextType {
  matlador: Matlada[];
  addMatlada: (newMatlada: Matlada) => void;
}

const MatladaContext = createContext<ContextType>({
  matlador: [],
  addMatlada: () => {}
});

const MatladaProvider: React.FC<{children: ReactNode}> = ({ children }) => {
  const [matlador, setMatlador] = useState<Matlada[]>([]);

  const addMatlada = (newMatlada: Matlada) => {
    setMatlador(prevMatlador => [...prevMatlador, newMatlada]);
  };

  return (
    <MatladaContext.Provider value={{ matlador, addMatlada }}>
      {children}
    </MatladaContext.Provider>
  );
};

export { MatladaContext, MatladaProvider };
