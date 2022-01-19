import React from 'react';
import GameDetails from 'components/GameDetails';
import SubMenu from 'components/SubMenu';
import HomeTemplate from 'Templates/HomeTemplate';

const GameDetailsPage = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <GameDetails />
    </HomeTemplate>
  );
};

export default GameDetailsPage;
