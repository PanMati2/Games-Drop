import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { getGames } from 'slices/GetGamesSlice';
import PropTypes from 'prop-types';
import { CircularProgress, withStyles } from '@material-ui/core';
import styles from './styles';
import GameCard from 'components/GameCard';

const Recommended = ({ classes }) => {
  const dispatch = useDispatch();
  const gamesData = useSelector((state) => state.GetGamesSlice);
  const { isLoading, games } = gamesData;
  useEffect(() => {
    dispatch(getGames());
  }, []);

  return (
    <div className={classes.container}>
      {isLoading ? (
        <div className={classes.loadingCircularContainer}>
          <CircularProgress size={60} />
        </div>
      ) : (
        <>
          {games
            .filter((game) => game.recommended === true)
            .slice(-9)
            .reverse()
            .map((game) => (
              <GameCard key={game.id} game={game} />
            ))}
        </>
      )}
    </div>
  );
};

Recommended.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Recommended);
