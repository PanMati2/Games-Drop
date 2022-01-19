import PSGames from 'components/Games/PSGames';
import SubMenu from 'components/SubMenu';
import React from 'react';
import HomeTemplate from 'Templates/HomeTemplate';

const PSGamesPage = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <PSGames />
    </HomeTemplate>
  );
};

export default PSGamesPage;
