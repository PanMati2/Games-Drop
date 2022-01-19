import Checkout from 'components/ShoppingCart/Checkout';
import SubMenu from 'components/SubMenu';
import React from 'react';
import HomeTemplate from 'Templates/HomeTemplate';

const CheckoutPage = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <Checkout />
    </HomeTemplate>
  );
};

export default CheckoutPage;
