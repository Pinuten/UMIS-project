import React, { useState } from 'react';
import './styles.css';

type MatladaFormState = {
  name: string;
  size: 'Normal' | 'Small';
};

export const CreateMatladaForm: React.FC = () => {
  const [formState, setFormState] = useState<MatladaFormState>({ name: '', size: 'Normal' });

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

    console.log('Posting matlåda:', matladaToPost);



    try {
      const response = await fetch('http://localhost:5165/api/Matlada', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json; charset=utf-8',
        },
        body: JSON.stringify(matladaToPost),
      });

      if (response.ok) {
        alert('Matlåda created successfully!');
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
        <label htmlFor="name">Name:</label>
        <input
          type="text"
          id="name"
          name="name"
          value={formState.name}
          onChange={handleChange}
          required
        />
      </div>
      <div>
        <label htmlFor="size">Size:</label>
        <select
          id="size"
          name="size"
          value={formState.size}
          onChange={handleChange}
          required
        >
          <option value="Normal">Normal</option>
          <option value="Small">Small</option>
        </select>
      </div>
      <button type="submit">Create Matlåda</button>
    </form>
  );
};

export default CreateMatladaForm;
