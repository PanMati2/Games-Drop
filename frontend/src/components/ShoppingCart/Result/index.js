import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import PropTypes from 'prop-types';
import { Typography, withStyles } from '@material-ui/core';
import { getCart } from 'slices/GetCartSlice';
import styles from './styles';

const Result = ({ classes }) => {
  const dispatch = useDispatch();
  const cartData = useSelector((state) => state.GetCartSlice.games);

  useEffect(() => {
    dispatch(getCart());
  }, []);

  return (
    <div className={classes.container}>
      <Typography variant="subtitle1">Zakup został pomyślnie zrealizowany!</Typography>
      {cartData.map((data) => (
        <Typography key={data.game.id} variant="subtitle2">
          Twój klucz do gry {data.game.title} to:{' '}
          {Math.random().toString(36).substring(2, 7) +
            '-' +
            Math.random().toString(36).substring(2, 7) +
            '-' +
            Math.random().toString(36).substring(2, 7) +
            '-' +
            Math.random().toString(36).substring(2, 7) +
            '-' +
            Math.random().toString(36).substring(2, 7)}
        </Typography>
      ))}
    </div>
  );
};

Result.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Result);
