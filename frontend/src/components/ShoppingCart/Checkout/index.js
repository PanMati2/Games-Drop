import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { getCart } from 'slices/GetCartSlice';
import PropTypes from 'prop-types';
import { Typography, withStyles, Button, Link } from '@material-ui/core';
import styles from './styles';
import Product from './Product';

const Checkout = ({ classes }) => {
  const dispatch = useDispatch();
  const cartData = useSelector((state) => state.GetCartSlice);
  const { games, isError } = cartData;
  const totalPrice = useSelector((state) => state.TotalPriceSlice.totalPrice);

  useEffect(() => {
    dispatch(getCart());
  }, []);

  return (
    <div className={classes.container}>
      {isError ? (
        <Typography>Brak gier w koszyku</Typography>
      ) : (
        <>
          {games.map((data) => (
            <Product key={data.game.id} gameData={data} />
          ))}
          <div className={classes.summary}>
            <Typography variant="subtitle2">Suma do zapłaty: {totalPrice}zł</Typography>
            <Link underline="none" href="/payment">
              <Button color="primary" variant="contained">
                Do kasy
              </Button>
            </Link>
          </div>
        </>
      )}
    </div>
  );
};

Checkout.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Checkout);
