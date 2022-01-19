import React, { useRef, useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import {
  register as registerSlice,
  clearState as ClearStateRegister,
} from 'slices/RegisterSlice.js';
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

const Register = ({ classes }) => {
  const dispatch = useDispatch();
  const registerData = useSelector((state) => state.RegisterSlice);
  const { errorMessage, isLoading, isError, isSuccess } = registerData;

  const {
    handleSubmit,
    control,
    register,
    watch,
    formState: { errors },
  } = useForm();
  const password = useRef({});
  password.current = watch('password', '');

  const onSubmit = (data) => {
    dispatch(registerSlice(data));
  };

  useEffect(() => {
    dispatch(ClearStateRegister());
  }, []);

  return (
    <>
      <Paper elevation={5} className={classes.paper}>
        {isSuccess ? (
          <>
            <Typography variant="subtitle2">Konto zostało pomyślanie utworzone!</Typography>
            <Typography variant="subtitle2">
              <Link underline="none" className={classes.link} href="/login">
                Przejdź do strony logowania, aby wejść na swoje konto.
              </Link>
            </Typography>
          </>
        ) : (
          <>
            <Typography variant="subtitle1">Rejestracja</Typography>

            {isError && (
              <MuiAlert elevation={6} variant="filled" severity="error">
                {errorMessage}
              </MuiAlert>
            )}

            <form onSubmit={handleSubmit(onSubmit)} className={classes.formContainer}>
              <Controller
                name="email"
                render={({ field }) => (
                  <TextField
                    {...register('email', {
                      required: 'Wpisz swój e-mail',
                      pattern: {
                        value: /^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$/i,
                        message: 'Niepoprawny adres e-mail',
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
              <Controller
                name="confirmedPassword"
                render={({ field }) => (
                  <TextField
                    {...register('confirmedPassword', {
                      required: 'To pole jest wymagane',
                      validate: (value) => value === password.current || 'Hasła nie pasują',
                    })}
                    {...field}
                    label="Potwierdź Hasło"
                    variant="outlined"
                    type="password"
                    helperText={errors.confirmedPassword && errors.confirmedPassword.message}
                    error={errors.confirmedPassword ? true : false}
                  />
                )}
                control={control}
                defaultValue=""
              />
              <Controller
                name="firstName"
                render={({ field }) => (
                  <TextField
                    {...register('firstName', {
                      required: true,
                    })}
                    {...field}
                    label="Imię"
                    variant="outlined"
                    type="text"
                    helperText={errors.firstName && 'To pole jest wymagane'}
                    error={errors.firstName ? true : false}
                  />
                )}
                control={control}
                defaultValue=""
              />
              <Controller
                name="lastName"
                render={({ field }) => (
                  <TextField
                    {...register('lastName', {
                      required: true,
                    })}
                    {...field}
                    label="Nazwisko"
                    variant="outlined"
                    type="text"
                    helperText={errors.lastName && 'To pole jest wymagane'}
                    error={errors.lastName ? true : false}
                  />
                )}
                control={control}
                defaultValue=""
              />
              <Controller
                name="mobilePhone"
                render={({ field }) => (
                  <TextField
                    {...register('mobilePhone', {
                      required: true,
                      pattern: {
                        value: /^-?[0-9]\d*\.?\d*$/,
                        message: 'Niepoprawny numer telefonu',
                      },
                    })}
                    {...field}
                    label="Numer telefonu"
                    variant="outlined"
                    helperText={errors.mobilePhone && errors.mobilePhone.message}
                    error={errors.mobilePhone ? true : false}
                  />
                )}
                control={control}
                defaultValue=""
              />
              {isLoading ? <CircularProgress /> : null}
              <Link className={classes.link} href="/login">
                Masz już konto? Zaloguj się!
              </Link>
              <Button type="submit" variant="contained" color="primary" className={classes.button}>
                Zarejestruj
              </Button>
            </form>
          </>
        )}
      </Paper>
    </>
  );
};

Register.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Register);
