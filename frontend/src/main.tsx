import React from 'react';
import ReactDOM from 'react-dom/client';
import { Auth0Provider } from '@auth0/auth0-react';
import App from './App';  // Assuming App.tsx is exported as App
import './index.css';

const root = ReactDOM.createRoot(document.getElementById('root')!);

root.render(
  <React.StrictMode>
    <Auth0Provider
      domain="dev-h620c8r7o048lorb.us.auth0.com"
      clientId="gxCQwcMwygDgBPnUH1fA9ubF3erwyQGx"
      redirectUri={window.location.origin}
    >
      <App />
    </Auth0Provider>
  </React.StrictMode>
);
