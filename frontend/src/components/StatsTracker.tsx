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

  useEffect(() => {
    const loadData = async () => {
      try {
        const data = await fetchEatenData();
        const calculatedAmount = data * 154;
        setAmountSaved(calculatedAmount);
      } catch (error) {
        console.error(error);
        alert('Failed to fetch data');
      }
    };

    loadData();
  }, []); 

  return (
    <div>
      <button onClick={() => setShowInfo(!showInfo)}>
        {showInfo ? 'Hide Info' : 'Show Info'}
      </button>
      {showInfo && amountSaved !== null && (
        <p>You have saved {amountSaved} amount by eating matlådor instead of eating out.</p>
      )}
    </div>
  );
};

export default StatsTracker;
