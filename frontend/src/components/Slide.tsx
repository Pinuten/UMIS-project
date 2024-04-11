import React, { useState, useEffect } from 'react';
import './styles.css';
import Add from './Add';
import Stove from '/src/assets/Stove.png';

const MatladaFormContainer: React.FC = () => {
  const [showForm, setShowForm] = useState(false);
  const [animationClass, setAnimationClass] = useState('');

  const toggleForm = () => {
    if (showForm) {
      setAnimationClass('slide-out');
      setTimeout(() => setShowForm(false), 500); 
    } else {
      setShowForm(true);
      setAnimationClass('slide-in');
    }
  };

  useEffect(() => {
    if (showForm) {
      setAnimationClass('slide-in');
    }
  }, [showForm]);

  return (
    <>
      <button onClick={toggleForm}>
        {showForm ? 'Close Matlåda Form' : 'Open Matlåda Form'}
      </button>
      {showForm && (
        <div className={`matlada-form-container ${animationClass}`}>
          <Add/>
          <img src={Stove} alt="stove" width= "300" />
        </div>
      )}
    </>
  );
};

export default MatladaFormContainer;
