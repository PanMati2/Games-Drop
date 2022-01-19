import SubMenu from 'components/SubMenu';
import React from 'react';
import HomeTemplate from 'Templates/HomeTemplate';
import Result from 'components/ShoppingCart/Result';

const ResultPages = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <Result />
    </HomeTemplate>
  );
};

export default ResultPages;
