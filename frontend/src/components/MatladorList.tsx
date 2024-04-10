import React, { useEffect, useState } from 'react';

// Define TypeScript interface for Matlada
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
    fetchMatlador(); // Call fetchMatlador on component mount
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

  return (
    <div>
      <h2>Matlådor List</h2>
      {matlador.length > 0 ? (
        <ul>
          {matlador.map((matlada) => (
            <li key={matlada.id}>
              {matlada.name} - Size: {matlada.size}, Created At: {new Date(matlada.createdAt).toLocaleDateString()}
              <button onClick={() => deleteMatlada(matlada.id)} style={{ marginLeft: '10px' }}>
                Delete
              </button>
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
