import XboxGames from 'components/Games/XboxGames';
import SubMenu from 'components/SubMenu';
import React from 'react';
import HomeTemplate from 'Templates/HomeTemplate';

const PCGamesPage = () => {
  return (
    <HomeTemplate>
      <SubMenu />
      <XboxGames />
    </HomeTemplate>
  );
};

export default PCGamesPage;
