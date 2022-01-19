import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { getGames } from 'slices/GetGamesSlice';
import PropTypes from 'prop-types';
import { Typography, withStyles, CircularProgress } from '@material-ui/core';
import styles from './styles';
import GameCard from 'components/GameCard';
import SubMenu from 'components/SubMenu';

const SearchResult = ({ classes }) => {
  const dispatch = useDispatch();
  const searchValue = useSelector((state) => state.SearchSlice.searchValue);
  const gamesData = useSelector((state) => state.GetGamesSlice);
  const { isLoading, games } = gamesData;

  useEffect(() => {
    dispatch(getGames());
  }, []);

  return (
    <div className={classes.container}>
      <SubMenu />
      <div className={classes.games}>
        {isLoading ? (
          <div className={classes.loadingCircularContainer}>
            <CircularProgress size={60} />
          </div>
        ) : (
          <>
            {games
              .filter(
                (game) =>
                  game.title.toLowerCase().includes(searchValue.toLowerCase()) ||
                  game.title.toLowerCase().includes(searchValue.toLowerCase())
              )
              .slice(-9)
              .reverse()
              .map((game) => (
                <GameCard key={game.id} game={game} />
              ))}
          </>
        )}
      </div>
      <Typography>{searchValue}</Typography>
    </div>
  );
};

SearchResult.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(SearchResult);
