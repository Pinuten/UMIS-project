import React, { useState } from 'react';
import { useAuth0 } from '@auth0/auth0-react'; 
import './styles.css';

type MatladaFormState = {
  name: string;
  size: 'Normal' | 'Small';
};

export const CreateMatladaForm: React.FC = () => {
  const [formState, setFormState] = useState<MatladaFormState>({ name: '', size: 'Normal' });
  const { getAccessTokenSilently } = useAuth0(); 

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>) => {
    const { name, value } = e.target;
    setFormState(prevState => ({ ...prevState, [name]: value }));
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    
    const sizeEnumValue = formState.size === 'Normal' ? 0 : 1;
    const matladaToPost = {
      name: formState.name,
      size: sizeEnumValue,
    };

    try {
      const accessToken = await getAccessTokenSilently(); 
      console.log(accessToken);
      const response = await fetch('http://localhost:5165/api/Matlada', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json; charset=utf-8',
          'Authorization': `Bearer ${accessToken}`, 
        },
        body: JSON.stringify(matladaToPost),
      });

      if (response.ok) {
        setFormState({ name: '', size: 'Normal' });
      } else {
        const errorResponse = await response.text();
        console.error('Failed to create Matlåda:', errorResponse);
        alert('Failed to create Matlåda. Please try again.');
      }
    } catch (error) {
      console.error('Error posting new Matlåda:', error);
      alert('An error occurred. Please try again.');
    }
  };

  return (
    <form onSubmit={handleSubmit} className="matlada-form">
      <div>
        <input
          type="text"
          id="name"
          name="name"
          placeholder='What did you cook?'
          value={formState.name}
          onChange={handleChange}
          required
        />
      </div>
      <div>
        <select
          id="size"
          name="size"
          value={formState.size}
          onChange={handleChange}
          required
        >
          <option value="Normal">Lunch</option>
          <option value="Small">Snack</option>
        </select>
      </div>
      <button type="submit">Add</button>
    </form>
  );
};

export default CreateMatladaForm;
