import React, { useState, useEffect } from 'react';

const fetchEatenData = async (): Promise<number> => {
    const response = await fetch("http://localhost:5165/api/Matlada/Eaten");
    if (!response.ok) {
        throw new Error(`Error: ${response.status}`);
    }
    const data: number = await response.json();
    return data;
};

const StatsTracker = () => {
  const [amountSaved, setAmountSaved] = useState<number | null>(null);
  const [showInfo, setShowInfo] = useState(false);
  const [message, setMessage] = useState('');

  const messages = [
    "You have saved {0}kr by choosing eco-friendly options.",
    "Your eco-friendly choices have saved you {0}kr.",
    "Thanks to your choices, you've saved {0}kr.",
    "Honey has an infinite shelf life.",
    "Make sure to let your food cool before poping it in the fridge", 
    "Consider donating your food before it goes bad."
  ];

  useEffect(() => {
    const loadData = async () => {
      try {
        const data = await fetchEatenData();
        const calculatedAmount = data * 154;
        setAmountSaved(calculatedAmount);
        updateMessage(calculatedAmount);  
      } catch (error) {
        console.error(error);
        alert('Failed to fetch data');
      }
    };

    loadData();
  }, []); 

  const updateMessage = (savedAmount:any) => {
    const randomMessageTemplate = messages[Math.floor(Math.random() * messages.length)];
    setMessage(randomMessageTemplate.replace("{0}", savedAmount.toString()));
  };

  const toggleInfo = () => {
    setShowInfo(!showInfo);
    if (amountSaved !== null) {
      updateMessage(amountSaved);
    }
  };

  return (
    <div>
      <button onClick={toggleInfo}>
        {showInfo ? 'Hide Info' : 'Show Info'}
      </button>
      {showInfo && amountSaved !== null && (
        <p>{message}</p> 
      )}
    </div>
  );
};

export default StatsTracker;
