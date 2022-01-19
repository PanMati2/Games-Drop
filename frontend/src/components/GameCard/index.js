import React from 'react';
import { useDispatch } from 'react-redux';
import { setSearchValue } from 'slices/SearchSlice';
import { AddToCart } from 'slices/AddToCartSlice';
import PropTypes from 'prop-types';
import { useHistory } from 'react-router-dom';
import { Divider, Typography, withStyles, IconButton } from '@material-ui/core';
import styles from './styles';
import AddShoppingCartIcon from '@material-ui/icons/AddShoppingCart';
import img from 'img/img.jpg';

const GameCard = ({ classes, game }) => {
  const dispatch = useDispatch();
  const history = useHistory();
  const OpenGameDetails = () => {
    dispatch(setSearchValue(''));
    history.push(`/game-details/${game.id}`);
  };

  const addToCart = () => {
    const data = {
      gameId: game.id,
    };
    dispatch(AddToCart(data));
  };

  return (
    <div className={classes.container}>
      {game.percentDiscount > 0 && (
        <div className={classes.discount}>
          <Typography variant="subtitle2">-{game.percentDiscount}%</Typography>
        </div>
      )}
      <div onClick={OpenGameDetails} className={classes.cover}>
        <img src={game.coverUrl ? game.coverUrl : img} alt={game.title} />
      </div>
      <div className={classes.details}>
        <div className={classes.title}>
          <Typography>{game.title}</Typography>
        </div>
        <Divider className={classes.divider} />
        <div className={classes.price}>
          <Typography>PLN {game.price}</Typography>

          <IconButton
            className={classes.basket}
            color="secondary"
            aria-label="basket shop"
            component="span"
            onClick={addToCart}
          >
            <AddShoppingCartIcon />
          </IconButton>
        </div>
      </div>
    </div>
  );
};

GameCard.propTypes = {
  classes: PropTypes.object.isRequired,
  game: PropTypes.object,
};

export default withStyles(styles)(GameCard);
