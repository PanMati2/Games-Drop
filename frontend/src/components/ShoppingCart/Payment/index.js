import React from 'react';
import PropTypes from 'prop-types';
import {
  Divider,
  Typography,
  withStyles,
  Radio,
  RadioGroup,
  FormControlLabel,
  FormControl,
  Button,
  Link,
} from '@material-ui/core';
import styles from './styles';

const Payment = ({ classes }) => {
  const [value, setValue] = React.useState('female');

  const name = localStorage.getItem('firstName');
  const email = localStorage.getItem('email');

  const handleChange = (event) => {
    setValue(event.target.value);
  };
  return (
    <div className={classes.container}>
      <div className={classes.billing}>
        <Typography variant="subtitle2">Informacje o kliencie:</Typography>
        <div className={classes.billingDetails}>
          <Typography variant="subtitle2">Imię:</Typography>
          <Typography variant="body2">{name}</Typography>
          <Typography variant="subtitle2">Adres Email:</Typography>
          <Typography variant="body2">{email}</Typography>
        </div>
      </div>
      <Divider className={classes.divider} orientation="vertical" />
      <div className={classes.paymentMethod}>
        <FormControl className={classes.formControl} component="fieldset">
          <Typography variant="subtitle2">Wybierz metodę płatności</Typography>
          <RadioGroup aria-label="billing" name="billing" value={value} onChange={handleChange}>
            <FormControlLabel value="paypal" control={<Radio color="primary" />} label="Paypal" />
            <FormControlLabel
              value="przelewy24"
              control={<Radio color="primary" />}
              label="Przelewy 24"
            />
            <FormControlLabel value="other" control={<Radio color="primary" />} label="Inne" />
          </RadioGroup>
          <div className={classes.button}>
            <Link underline="none" href="/result">
              <Button color="primary" variant="contained">
                Zapłać
              </Button>
            </Link>
          </div>
        </FormControl>
      </div>
    </div>
  );
};

Payment.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Payment);
