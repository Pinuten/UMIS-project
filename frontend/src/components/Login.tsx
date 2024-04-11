import { useAuth0 } from '@auth0/auth0-react';

const AuthenticationButton: React.FC = () => {
    const { isAuthenticated, loginWithRedirect, logout } = useAuth0();
  
    if (!isAuthenticated) {
      return <button onClick={() => loginWithRedirect()}>Log In</button>;
    }
  
    return <button onClick={() => logout({ returnTo: window.location.origin })}>Log Out</button>;
  };
  