import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { getGames } from 'slices/GetGamesSlice';
import PropTypes from 'prop-types';
import { useForm, Controller } from 'react-hook-form';
import { addSales as addSalesGame } from 'slices/AddSalesSlice';
import {
  Typography,
  withStyles,
  Paper,
  Select,
  MenuItem,
  Button,
  TextField,
  InputLabel,
  FormHelperText,
  CircularProgress,
  Link,
} from '@material-ui/core';
import MuiAlert from '@material-ui/lab/Alert';
import styles from './styles';

const AddSales = ({ classes }) => {
  const dispatch = useDispatch();
  const AddGameSales = useSelector((state) => state.AddSalesSlice);
  const getGamesList = useSelector((state) => state.GetGamesSlice.games);
  const { errorMessage, isLoading, isError, isSuccess } = AddGameSales;

  const [openGameSelect, setOpenGameSelect] = React.useState(false);

  const handleCloseGameSelect = () => {
    setOpenGameSelect(false);
  };

  const handleOpenGameSelect = () => {
    setOpenGameSelect(true);
  };

  const {
    handleSubmit,
    control,
    register,
    formState: { errors },
  } = useForm();

  useEffect(() => {
    dispatch(getGames());
  }, []);

  const onSubmit = (data) => {
    dispatch(addSalesGame(data));
  };

  return (
    <Paper elevation={5} className={classes.paper}>
      {isSuccess ? (
        <>
          <Typography variant="subtitle2">Promocja została dodana pomyślnie!</Typography>
          <Typography variant="subtitle2">
            <Link underline="none" href="/admin-panel/sales">
              Dodaj kolejną promocję.
            </Link>
          </Typography>
        </>
      ) : (
        <>
          {isError && (
            <MuiAlert elevation={6} variant="filled" severity="error">
              {errorMessage}
            </MuiAlert>
          )}
          <Typography className={classes.text} variant="subtitle1">
            Dodaj Promocje
          </Typography>
          <form className={classes.formContainer} onSubmit={handleSubmit(onSubmit)}>
            <InputLabel className={classes.inputColor} id="categories-label">
              Wybierz Grę:
            </InputLabel>
            <Controller
              name="gameId"
              render={({ field }) => (
                <>
                  <Select
                    {...register('gameId', {
                      required: 'To pole jest wymagane',
                    })}
                    {...field}
                    className={classes.inputColor}
                    labelid="gameId-label"
                    id="gameId-open-select"
                    open={openGameSelect}
                    onClose={handleCloseGameSelect}
                    onOpen={handleOpenGameSelect}
                    variant="filled"
                    error={errors.gameId ? true : false}
                  >
                    {getGamesList.map((game) => (
                      <MenuItem key={game.id} value={game.id}>
                        {game.title}
                      </MenuItem>
                    ))}
                  </Select>
                  <FormHelperText className={classes.helperText}>
                    {errors.gameId && errors.gameId.message}
                  </FormHelperText>
                </>
              )}
              control={control}
              defaultValue=""
            />
            <InputLabel className={classes.inputColor} id="title-label">
              Podaj o ile procent obniżyć grę:
            </InputLabel>
            <Controller
              render={({ field }) => (
                <TextField
                  {...register('percentDiscount', {
                    required: 'To pole jest wymagane',
                  })}
                  {...field}
                  type="text"
                  labelid="percentDiscount-label"
                  variant="filled"
                  helperText={errors.percentDiscount && errors.percentDiscount.message}
                  error={errors.percentDiscount ? true : false}
                />
              )}
              name="percentDiscount"
              control={control}
              defaultValue=""
            />
            <Button variant="contained" color="primary" className={classes.button} type="submit">
              Dodaj
            </Button>
            {isLoading && <CircularProgress />}
          </form>
        </>
      )}
    </Paper>
  );
};

AddSales.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(AddSales);
