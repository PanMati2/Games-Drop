import Heading from 'components/Heading';
import Recommended from 'components/Recommended';
import SalesBox from 'components/SalesBox';
import SubMenu from 'components/SubMenu';
import React from 'react';
import HomeTemplate from 'Templates/HomeTemplate';

const HomePage = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <SalesBox />
      <Heading type="big" title="polecane gry" />
      <Recommended />
    </HomeTemplate>
  );
};

export default HomePage;
