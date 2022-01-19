import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { useHistory } from 'react-router-dom';
import { login, clearState } from 'slices/LoginSlice';
import PropTypes from 'prop-types';
import { useForm, Controller } from 'react-hook-form';
import {
  Button,
  Link,
  TextField,
  Typography,
  withStyles,
  Paper,
  CircularProgress,
} from '@material-ui/core';
import MuiAlert from '@material-ui/lab/Alert';
import styles from './styles';

const Login = ({ classes }) => {
  const history = useHistory();
  const dispatch = useDispatch();
  const loginData = useSelector((state) => state.LoginSlice);
  const { errorMessage, isLoading, isError, isSuccess } = loginData;

  const {
    handleSubmit,
    control,
    register,
    formState: { errors },
  } = useForm();

  const onSubmit = (data) => {
    dispatch(login(data));
  };

  useEffect(() => {
    dispatch(clearState());
  }, []);

  useEffect(() => {
    if (isSuccess) {
      history.push('/');
      dispatch(clearState());
    }
  }, [isSuccess]);

  return (
    <>
      <Paper elevation={5} className={classes.paper}>
        {isError && (
          <MuiAlert elevation={6} variant="filled" severity="error">
            {errorMessage}
          </MuiAlert>
        )}
        <Typography variant="subtitle1">Logowanie</Typography>
        <form onSubmit={handleSubmit(onSubmit)} className={classes.formContainer}>
          <Controller
            name="email"
            render={({ field }) => (
              <TextField
                {...register('email', {
                  required: 'To pole jest wymagane',
                  pattern: {
                    value: /^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$/i,
                    message: 'Niepoprwany adres e-mail',
                  },
                })}
                {...field}
                label="Email"
                variant="outlined"
                type="email"
                helperText={errors.email && errors.email.message}
                error={errors.email ? true : false}
              />
            )}
            control={control}
            defaultValue=""
          />
          <Controller
            name="password"
            render={({ field }) => (
              <TextField
                {...register('password', {
                  required: 'To pole jest wymagane',
                  pattern: {
                    value: /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\s).{8,20}$/,
                    message:
                      'Hasło musi składac się z przynajmniej jeden liczby,znaku specjalnego, jednej wielkiej litery i małej oraz musi zawierać od 8 do 20 znaków.',
                  },
                })}
                {...field}
                label="Hasło"
                variant="outlined"
                type="password"
                helperText={errors.password && errors.password.message}
                error={errors.password ? true : false}
              />
            )}
            control={control}
            defaultValue=""
          />
          {isLoading ? <CircularProgress /> : null}
          <Button type="submit" variant="contained" color="primary" className={classes.button}>
            Zaloguj się
          </Button>
          <Link underline="none" href="/register">
            <Button variant="contained" color="primary" className={classes.button}>
              Rejestracja
            </Button>
          </Link>
        </form>
      </Paper>
    </>
  );
};

Login.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Login);
