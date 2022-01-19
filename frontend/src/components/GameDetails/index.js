import React, { useEffect } from 'react';
import PropTypes from 'prop-types';
import { useDispatch, useSelector } from 'react-redux';
import { getGames } from 'slices/GetGamesSlice';
import { AddToCart } from 'slices/AddToCartSlice';
import { useHistory } from 'react-router-dom';
import { Typography, withStyles, Paper, Button, CircularProgress } from '@material-ui/core';
import AddShoppingCartIcon from '@material-ui/icons/AddShoppingCart';
import styles from './styles';
import Heading from 'components/Heading';

const GameDetails = ({ classes }) => {
  const dispatch = useDispatch();
  const gamesData = useSelector((state) => state.GetGamesSlice);
  const { games, isSuccess, isLoading } = gamesData;
  const history = useHistory();

  const gameDetails = games.filter((game) => game.id == history.location.pathname.slice(14, 20));

  useEffect(() => {
    dispatch(getGames());
  }, []);

  let re =
    /^(https?:\/\/)?((www\.)?(youtube(-nocookie)?|youtube.googleapis)\.com.*(v\/|v=|vi=|vi\/|e\/|embed\/|user\/.*\/u\/\d+\/)|youtu\.be\/)([_0-9a-z-]+)/i;

  const addToCart = () => {
    const data = {
      gameId: gameDetails[0].id,
    };
    dispatch(AddToCart(data));
  };

  return (
    <div className={classes.container}>
      {isLoading ? (
        <CircularProgress />
      ) : (
        <>
          {isSuccess && (
            <>
              <div className={classes.leftBox}>
                <img src={gameDetails[0].coverUrl} alt={gameDetails[0].title} />
              </div>
              <Paper className={classes.rightBox}>
                <Heading type="small" title={gameDetails[0].title} />
                <div className={classes.informations}>
                  <div className={classes.heading}>
                    <Typography variant="subtitle2">
                      Urządzenie:{' '}
                      <Typography variant="body2">{gameDetails[0].deviceName}</Typography>
                    </Typography>
                    <Typography variant="subtitle2">
                      Platforma:{' '}
                      <Typography variant="body2">{gameDetails[0].platformName}</Typography>
                    </Typography>
                    <Typography variant="subtitle2">
                      System operacyjny:{' '}
                      <Typography variant="body2">{gameDetails[0].operatingSystemName}</Typography>
                    </Typography>
                    <Typography variant="subtitle2">
                      Gatunek: <Typography variant="body2">Przygoda</Typography>
                    </Typography>
                    <Typography variant="subtitle2">
                      Cena: <Typography variant="body2">{gameDetails[0].price}zł</Typography>
                    </Typography>
                  </div>
                  <div className={classes.description}>
                    <Typography variant="subtitle2">
                      Opis gry:
                      <Typography variant="body2">{gameDetails[0].description}</Typography>
                    </Typography>
                  </div>
                  <div className={classes.trailer}>
                    <Heading type="small" title="Zwiastun" />
                    <iframe
                      width="560"
                      height="315"
                      src={`https://www.youtube.com/embed/${
                        gameDetails[0].trailerUrl.match(re)[7]
                      }`}
                      title="YouTube video player"
                      frameBorder="0"
                      allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                      allowFullScreen
                    ></iframe>
                  </div>

                  <div className={classes.button}>
                    <Button
                      onClick={addToCart}
                      variant="contained"
                      color="secondary"
                      endIcon={<AddShoppingCartIcon />}
                    >
                      Do koszyka
                    </Button>
                  </div>
                </div>
              </Paper>
            </>
          )}
        </>
      )}
    </div>
  );
};

GameDetails.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(GameDetails);
