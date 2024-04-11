import React, { useEffect, useState } from 'react';
import './styles.css'
import trashIcon from '/src/assets/trashIcon.svg';
import eatIcon from '/src/assets/eatIcon.svg';



interface Matlada {
  id: number;
  guid: string;
  size: 'Normal' | 'Small';
  createdAt: string;
  name: string;
}

const MatladaList: React.FC = () => {
  const [matlador, setMatlador] = useState<Matlada[]>([]);

  useEffect(() => {
    fetchMatlador();
  }, []);

  const fetchMatlador = async () => {
    try {
      const response = await fetch('http://localhost:5165/api/Matlada');
      const data = await response.json();
      setMatlador(data);
    } catch (error) {
      console.error("Error fetching data: ", error);
    }
  };

  const deleteMatlada = async (id: number) => {
    try {
      const response = await fetch(`http://localhost:5165/api/Matlada/${id}`, {
        method: 'DELETE',
      });
      if (!response.ok) {
        throw new Error('Failed to delete the matlåda.');
      }
      fetchMatlador();
    } catch (error) {
      console.error("Error deleting matlåda: ", error);
    }
  };

  const eatMatlada = async (id: number) => {
    try {
      const response = await fetch(`http://localhost:5165/api/Matlada/Eaten/${id}`, {
        method: 'POST',
      });
      if (!response.ok) {
        throw new Error('Failed to mark the matlåda as eaten.');
      }
      fetchMatlador();
    } catch (error) {
      console.error("Error marking matlåda as eaten: ", error);
    }
  };

  // Part of MatladaList.tsx
  return (
    <div className="matlada-list-container">
      <h2>Matlådor List</h2>
      {matlador.length > 0 ? (
        <ul className="matlada-list">
          {matlador.map((matlada) => (
            <li key={matlada.id} className="matlada-item">
              <div className="flip-card">
                <div className="flip-card-inner">
                  <div className="flip-card-front">
                    <span>{matlada.name}</span> {/* Display only the name or minimal info */}
                  </div>
                  <div className="flip-card-back">
                    Size: {matlada.size}, Created At: {new Date(matlada.createdAt).toLocaleDateString()}
                    <button onClick={() => deleteMatlada(matlada.id)} className="button-style">
                      <img src={trashIcon} alt="delete" />
                    </button>
                    <button onClick={() => eatMatlada(matlada.id)} className="button-style" >
                      <img src={eatIcon} alt="eat" />
                    </button>
                  </div>
                </div>
              </div>
            </li>
          ))}
        </ul>
      ) : (
        <p>No matlådor found.</p>
      )}
    </div>
  );

};

export default MatladaList;
