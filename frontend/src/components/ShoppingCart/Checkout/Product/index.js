import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { setPrice } from 'slices/TotalPriceSlice';
import { deleteCart } from 'slices/DeleteCartSlice';
import { getCart } from 'slices/GetCartSlice';
import PropTypes from 'prop-types';
import { Typography, withStyles } from '@material-ui/core';
import styles from './styles';
import DeleteIcon from '@material-ui/icons/Delete';

const Product = ({ classes, gameData }) => {
  const dispatch = useDispatch();
  const isSuccess = useSelector((state) => state.DeleteCartSlice.isSuccess);
  const { game } = gameData;

  useEffect(() => {
    const totalPrice = game.price * ((100 - game.percentDiscount) / 100) * gameData.quantity;
    dispatch(setPrice(totalPrice));
  }, []);

  useEffect(() => {
    if (isSuccess) {
      window.location.reload(true);
    }
  }, [isSuccess]);

  const deleteGame = () => {
    const data = {
      gameId: game.id,
    };
    dispatch(deleteCart(data));
    dispatch(getCart());
  };

  return (
    <div className={classes.products}>
      <div className={classes.cover}>
        <img src={game.coverUrl} alt={game.title} />
        <Typography>{game.title}</Typography>
      </div>
      <div className={classes.platform}>{game.platformName}</div>
      <div className={classes.quantity}>ilość: {gameData.quantity}</div>
      <div className={classes.subtotal}>{game.price * gameData.quantity}zł</div>
      <div className={classes.remove}>
        <DeleteIcon onClick={deleteGame} className={classes.removeIcon} />
      </div>
    </div>
  );
};

Product.propTypes = {
  classes: PropTypes.object.isRequired,
  gameData: PropTypes.object,
};

export default withStyles(styles)(Product);
