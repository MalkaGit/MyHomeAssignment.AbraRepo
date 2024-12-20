import React, { useState } from 'react';
import axios from 'axios';
import './App.css';

function App() {
  // State to store input values
  const [userId, setUserId] = useState('');
  const [loanAmount, setLoanAmount] = useState('');
  const [loanPeriod, setLoanPeriod] = useState('');
  const [loanDetails, setLoanDetails] = useState(null);
  const [error, setError] = useState('');

  // Validation function
  const validateFields = () => {
    if (!userId || !loanAmount || !loanPeriod) {
      setError('All fields are required.');
      return false;
    }
    if (isNaN(loanAmount) || loanAmount <= 0) {
      setError('Loan amount must be a positive number.');
      return false;
    }
    if (isNaN(loanPeriod) || loanPeriod <=11) {
      setError('Loan period must be  greater than 11.');
      return false;
    }
    setError('');
    return true;
  };

  // Fetch loan details from the backend server
  const fetchLoanDetails = async () => {
    if (!validateFields()) {
      return;
    }

    try {
      const response = await axios.post('http://localhost:5070/api/Loan', {
        ClientId: userId,
        RequestedAmount: loanAmount,
        LoanPeriodInMonths: loanPeriod
      });
      setLoanDetails(response.data);
    } catch (err) {
      if (err.response && err.response.status == 400)
      {         //console.log(err.response.data.message + "!")
      		setError(err.response.data.message);
      }
	else 
      		setError('Error fetching loan details. Please try again later.');
    }
  };

  return (
    <div className="App">
      <h1>Loan Suggestion</h1>

      {/* Error message */}
      {error && <div className="error">{error}</div>}

      {/* Loan Form */}
      <div className="form">
        <div className="form-field">
          <label>User ID</label>
          <input
            type="text"
            value={userId}
            onChange={(e) => setUserId(e.target.value)}
          />
        </div>
        <div className="form-field">
          <label>Loan Amount</label>
          <input
            type="number"
            value={loanAmount}
            onChange={(e) => setLoanAmount(e.target.value)}
          />
        </div>
        <div className="form-field">
          <label>Loan Period (months)</label>
          <input
            type="number"
            value={loanPeriod}
            onChange={(e) => setLoanPeriod(e.target.value)}
          />
        </div>
        <button onClick={fetchLoanDetails}>Get Loan Suggestion</button>
      </div>

      {/* Loan details popup */}
      {loanDetails && (
        <div className="popup">
          <h2>Loan Details</h2>
          <p>Total returned amount: {loanDetails.totalReturnedAmount}</p>
          <p>base Intrest: ${loanDetails.basicIntrest}</p>
          <p>Effective Prime Intrest:  {loanDetails.effectivePrimeIntrest}%</p>
          <p>Extra Month Intrest: ${loanDetails.extraMonthIntrest}</p>
        </div>
      )}
    </div>
  );
}

export default App;
