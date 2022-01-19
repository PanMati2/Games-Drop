import SubMenu from 'components/SubMenu';
import React from 'react';
import HomeTemplate from 'Templates/HomeTemplate';
import Payment from 'components/ShoppingCart/Payment';

const PaymentPage = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <Payment />
    </HomeTemplate>
  );
};

export default PaymentPage;
