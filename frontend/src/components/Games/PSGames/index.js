import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { getGames } from 'slices/GetGamesSlice';
import PropTypes from 'prop-types';
import {
  Typography,
  withStyles,
  FormControl,
  InputLabel,
  Select,
  MenuItem,
  Divider,
  CircularProgress,
} from '@material-ui/core';
import styles from './styles';
import GameCard from 'components/GameCard';

const PSGames = ({ classes }) => {
  const dispatch = useDispatch();
  const gamesData = useSelector((state) => state.GetGamesSlice);
  const { isLoading, games } = gamesData;

  useEffect(() => {
    dispatch(getGames());
  }, []);

  const [category, setCategory] = React.useState('');
  const [open, setOpen] = React.useState(false);

  const handleChange = (event) => {
    setCategory(event.target.value);
  };

  const handleClose = () => {
    setOpen(false);
  };

  const handleOpen = () => {
    setOpen(true);
  };
  return (
    <div className={classes.container}>
      <Divider className={classes.divider} />
      <div className={classes.header}>
        <Typography>
          Dostępne gry na platformę: <b>PC</b>
        </Typography>
        <FormControl className={classes.formControl}>
          <InputLabel className={classes.inputColor} id="categories-open-select-label">
            Wybierz Kategorię:
          </InputLabel>
          <Select
            className={classes.inputColor}
            labelId="categories-open-select-label"
            id="categories-open-select"
            open={open}
            onClose={handleClose}
            onOpen={handleOpen}
            value={category}
            onChange={handleChange}
            variant="filled"
          >
            <MenuItem value={1}>Akcji</MenuItem>
            <MenuItem value={2}>Przygodowa</MenuItem>
            <MenuItem value={3}>Jednoosobowa</MenuItem>
            <MenuItem value={4}>Indie</MenuItem>
            <MenuItem value={5}>Strategiczna</MenuItem>
            <MenuItem value={6}>Symulacja</MenuItem>
            <MenuItem value={7}>Wieloosobowa</MenuItem>
            <MenuItem value={8}>RPG</MenuItem>
            <MenuItem value={9}>Casual</MenuItem>
          </Select>
        </FormControl>
      </div>
      <Divider className={classes.divider} />
      <div className={classes.games}>
        {isLoading ? (
          <div className={classes.loadingCircularContainer}>
            <CircularProgress size={60} />
          </div>
        ) : (
          <>
            {games
              .filter((game) => game.deviceName === 'Playstation')
              .filter((game) => category === '' || game.categoryId === category)
              .slice(-9)
              .reverse()
              .map((game) => (
                <GameCard key={game.id} game={game} />
              ))}
          </>
        )}
      </div>
    </div>
  );
};

PSGames.propTypes = {
  classes: PropTypes.object.isRequired,
  title: PropTypes.string,
};

export default withStyles(styles)(PSGames);
