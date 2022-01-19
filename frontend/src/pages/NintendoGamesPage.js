import NintendoGames from 'components/Games/NintendoGames';
import SubMenu from 'components/SubMenu';
import React from 'react';
import HomeTemplate from 'Templates/HomeTemplate';

const NintendoGamesPage = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <NintendoGames />
    </HomeTemplate>
  );
};

export default NintendoGamesPage;
