import PCGames from 'components/Games/PCGames';
import SubMenu from 'components/SubMenu';
import React from 'react';
import HomeTemplate from 'Templates/HomeTemplate';

const PCGamesPage = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <PCGames />
    </HomeTemplate>
  );
};

export default PCGamesPage;
