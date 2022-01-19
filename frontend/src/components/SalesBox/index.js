import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { getGames } from 'slices/GetGamesSlice';
import PropTypes from 'prop-types';
import { Paper, withStyles, CircularProgress, Typography } from '@material-ui/core';
import Slider from 'react-slick';
import styles from './styles';
import SalesCard from './SalesCard';
import 'slick-carousel/slick/slick.css';
import 'slick-carousel/slick/slick-theme.css';
import { Arrow } from './Arrows';

const SalesBox = ({ classes }) => {
  const settings = {
    className: classes.slide,
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
    nextArrow: <Arrow direction="next" />,
    prevArrow: <Arrow direction="prev" />,
  };

  const dispatch = useDispatch();
  const gamesData = useSelector((state) => state.GetGamesSlice);
  const { isLoading, games } = gamesData;

  useEffect(() => {
    dispatch(getGames());
  }, []);

  return (
    <>
      <Paper elevation={5} className={classes.banner}>
        <Typography variant="subtitle1">Promocje</Typography>
      </Paper>
      <Paper elevation={5} className={classes.paper}>
        {isLoading ? (
          <div className={classes.loadingCircularContainer}>
            <CircularProgress size={60} />
          </div>
        ) : (
          <Slider {...settings}>
            {games
              .filter((game) => game.recommended === true)
              .slice(-5)
              .reverse()
              .map((game) => (
                <SalesCard key={game.id} game={game} />
              ))}
          </Slider>
        )}
      </Paper>
    </>
  );
};

SalesBox.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(SalesBox);
