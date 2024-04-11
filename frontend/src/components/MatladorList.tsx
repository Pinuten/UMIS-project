import React, { useEffect, useState } from 'react';
import './styles.css'



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
  const getSizeDescription = (size: number) => {
    switch(size) {
      case 0: return "";
      case 1: return "Small";
      default: return "Unknown size"; 
    }
  };
  return (
    <div className="matlada-list-container">
      {matlador.length > 0 ? (
        <ul className="matlada-list">
          {matlador.map((matlada) => (
            <li key={matlada.id} className="matlada-item">
              <div className="flip-card">
                <div className="flip-card-inner">
                  <div className="flip-card-front">
                    <span>{matlada.name}</span>
                  </div>
                  <div className="flip-card-back">
                  {getSizeDescription(matlada.size)} Created At: {new Date(matlada.createdAt).toLocaleDateString()}
                    <div className="button-container">
                      <button onClick={() => deleteMatlada(matlada.id)} className="button-style">Throw away</button>
                      <button onClick={() => eatMatlada(matlada.id)} className="button-style" >Eat</button>
                    </div>
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
