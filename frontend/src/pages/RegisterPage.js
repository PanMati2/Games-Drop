import Register from 'components/Auth/Register';
import SubMenu from 'components/SubMenu';
import React from 'react';
import HomeTemplate from 'Templates/HomeTemplate';

const RegisterPage = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <Register />
    </HomeTemplate>
  );
};

export default RegisterPage;
