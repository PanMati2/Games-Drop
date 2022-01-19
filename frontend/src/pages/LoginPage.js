import Login from 'components/Auth/Login';
import SubMenu from 'components/SubMenu';
import React from 'react';
import HomeTemplate from 'Templates/HomeTemplate';

const LoginPage = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <Login />
    </HomeTemplate>
  );
};

export default LoginPage;
