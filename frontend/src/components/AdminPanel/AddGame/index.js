import React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import PropTypes from 'prop-types';
import { useForm, Controller } from 'react-hook-form';
import { addGame } from 'slices/AddGameSlice';
import {
  Typography,
  withStyles,
  Paper,
  Checkbox,
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

const AddGame = ({ classes }) => {
  const dispatch = useDispatch();
  const addGameData = useSelector((state) => state.AddGameSlice);
  const { errorMessage, isLoading, isError, isSuccess } = addGameData;

  const [openCategoriesSelect, setOpenCategoriesSelect] = React.useState(false);
  const [openPlatformSelect, setOpenPlatformSelect] = React.useState(false);

  const handleCloseCategories = () => {
    setOpenCategoriesSelect(false);
  };

  const handleOpenCategories = () => {
    setOpenCategoriesSelect(true);
  };

  const handleClosePlatform = () => {
    setOpenPlatformSelect(false);
  };

  const handleOpenPlatform = () => {
    setOpenPlatformSelect(true);
  };

  const {
    handleSubmit,
    control,
    register,
    formState: { errors },
  } = useForm();

  const onSubmit = (data) => {
    dispatch(addGame(data));
  };

  const categories = [
    { value: '1', text: 'Akcji' },
    { value: '2', text: 'Przygodowa' },
    { value: '3', text: 'Jednoosobowa' },
    { value: '4', text: 'Indie' },
    { value: '5', text: 'Strategiczna' },
    { value: '6', text: 'Symulacja' },
    { value: '7', text: 'Wieloosobowa' },
    { value: '8', text: 'RPG' },
    { value: '9', text: 'Casual' },
  ];

  const platforms = [
    { value: '1', text: 'Steam' },
    { value: '2', text: 'Epic Games' },
    { value: '3', text: 'Origin' },
    { value: '4', text: 'Playstation 4' },
    { value: '5', text: 'Playstation 5' },
    { value: '6', text: 'Xbox One' },
    { value: '7', text: 'Xbox Series' },
    { value: '8', text: 'Nintendo' },
  ];

  return (
    <Paper elevation={5} className={classes.paper}>
      {isSuccess ? (
        <>
          <Typography variant="subtitle2">Gra została dodana pomyślnie!</Typography>
          <Typography variant="subtitle2">
            <Link underline="none" href="/admin-panel/add">
              Dodaj kolejną gre.
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
          <Typography variant="subtitle1">Dodaj gre</Typography>
          <form className={classes.formContainer} onSubmit={handleSubmit(onSubmit)}>
            <InputLabel className={classes.inputColor} id="title-label">
              Tytuł:
            </InputLabel>
            <Controller
              render={({ field }) => (
                <TextField
                  {...register('title', {
                    required: 'To pole jest wymagane',
                  })}
                  {...field}
                  type="text"
                  labelid="title-label"
                  variant="filled"
                  helperText={errors.title && errors.title.message}
                  error={errors.title ? true : false}
                />
              )}
              name="title"
              control={control}
              defaultValue=""
            />
            <InputLabel className={classes.inputColor} id="price-label">
              Cena:
            </InputLabel>
            <Controller
              render={({ field }) => (
                <TextField
                  {...register('price', {
                    required: 'To pole jest wymagane',
                  })}
                  type="number"
                  labelid="price-label"
                  variant="filled"
                  {...field}
                  helperText={errors.price && errors.price.message}
                  error={errors.price ? true : false}
                />
              )}
              name="price"
              control={control}
              defaultValue=""
            />
            <InputLabel className={classes.inputColor} id="categories-label">
              Wybierz Kategorię:
            </InputLabel>
            <Controller
              name="categoryId"
              render={({ field }) => (
                <>
                  <Select
                    {...register('categoryId', {
                      required: 'To pole jest wymagane',
                    })}
                    {...field}
                    className={classes.inputColor}
                    labelid="categories-label"
                    id="categories-open-select"
                    open={openCategoriesSelect}
                    onClose={handleCloseCategories}
                    onOpen={handleOpenCategories}
                    variant="filled"
                    error={errors.categoryId ? true : false}
                  >
                    {categories.map((category) => (
                      <MenuItem key={category.value} value={category.value}>
                        {category.text}
                      </MenuItem>
                    ))}
                  </Select>
                  <FormHelperText className={classes.helperText}>
                    {errors.categoryId && errors.categoryId.message}
                  </FormHelperText>
                </>
              )}
              control={control}
              defaultValue=""
            />
            <InputLabel className={classes.inputColor} id="platform-label">
              Wybierz Platformę:
            </InputLabel>
            <Controller
              name="platformId"
              render={({ field }) => (
                <>
                  <Select
                    {...register('platformId', {
                      required: 'To pole jest wymagane',
                    })}
                    {...field}
                    className={classes.inputColor}
                    labelid="platform-label"
                    id="categories-open-select"
                    open={openPlatformSelect}
                    onClose={handleClosePlatform}
                    onOpen={handleOpenPlatform}
                    variant="filled"
                    error={errors.platformId ? true : false}
                  >
                    {platforms.map((platform) => (
                      <MenuItem key={platform.value} value={platform.value}>
                        {platform.text}
                      </MenuItem>
                    ))}
                  </Select>
                  <FormHelperText className={classes.helperText}>
                    {errors.platformId && errors.platformId.message}
                  </FormHelperText>
                </>
              )}
              control={control}
              defaultValue=""
            />
            <InputLabel className={classes.inputColor} id="description-label">
              Opis:
            </InputLabel>
            <Controller
              render={({ field }) => (
                <TextField
                  {...register('description', {
                    required: 'To pole jest wymagane',
                  })}
                  type="text"
                  multiline={true}
                  labelid="description-label"
                  variant="filled"
                  rows={5}
                  {...field}
                  helperText={errors.description && errors.description.message}
                  error={errors.description ? true : false}
                />
              )}
              name="description"
              control={control}
              defaultValue=""
            />
            <InputLabel className={classes.inputColor} id="cover-label">
              Link do okładki:
            </InputLabel>
            <Controller
              render={({ field }) => (
                <TextField
                  {...register('coverUrl', {
                    required: 'To pole jest wymagane',
                  })}
                  type="url"
                  labelid="cover-label"
                  variant="filled"
                  {...field}
                  helperText={errors.coverUrl && errors.coverUrl.message}
                  error={errors.coverUrl ? true : false}
                />
              )}
              name="coverUrl"
              control={control}
              defaultValue=""
            />
            <InputLabel className={classes.inputColor} id="trailer-label">
              Link do zwiastuna gry:
            </InputLabel>
            <Controller
              render={({ field }) => (
                <TextField
                  {...register('trailerUrl', {
                    required: 'To pole jest wymagane',
                  })}
                  type="url"
                  labelid="trailer-label"
                  variant="filled"
                  {...field}
                  helperText={errors.trailerUrl && errors.trailerUrl.message}
                  error={errors.trailerUrl ? true : false}
                />
              )}
              name="trailerUrl"
              control={control}
              defaultValue=""
            />
            <InputLabel className={classes.inputColor} id="recommended-label">
              Gra rekomendowana:
            </InputLabel>
            <Controller
              name="recommended"
              defaultValue={false}
              control={control}
              render={({ field }) => (
                <>
                  <Checkbox labelid="recommended-label" {...field} />
                </>
              )}
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

AddGame.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(AddGame);
