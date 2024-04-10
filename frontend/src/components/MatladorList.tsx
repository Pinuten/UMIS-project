// src/components/MatladorList.tsx
import React, { useEffect, useState } from 'react';
import { Matlada } from '../interfaces/Matlada';

const MatladorList: React.FC = () => {
  const [matlador, setMatlador] = useState<Matlada[]>([]);

  useEffect(() => {
    const fetchMatlador = async () => {
      try {
        const response = await fetch('http://localhost:5165/api/Matlada'); 
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        const data = await response.json() as Matlada[];
        setMatlador(data);
      } catch (error) {
        console.error('Failed to fetch matlador', error);
      }
    };

    fetchMatlador();
  }, []);

  return (
    <div>
      <h2>Matlådor</h2>
      <ul>
        {matlador.map(matlada => (
          <li key={matlada.id}>
            <p>Name: {matlada.name}</p>
            <p>Size: {matlada.size}</p>
            <p>Created At: {matlada.createdAt}</p>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default MatladorList;
