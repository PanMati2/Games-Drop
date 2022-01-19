import React from 'react';
import PropTypes from 'prop-types';
import { useHistory } from 'react-router-dom';
import { withStyles, Paper } from '@material-ui/core';
import styles from './styles';

const SalesCard = ({ classes, game }) => {
  let re =
    /^(https?:\/\/)?((www\.)?(youtube(-nocookie)?|youtube.googleapis)\.com.*(v\/|v=|vi=|vi\/|e\/|embed\/|user\/.*\/u\/\d+\/)|youtu\.be\/)([_0-9a-z-]+)/i;
  let imageId = game.trailerUrl.match(re)[7];

  const history = useHistory();
  const OpenGameDetails = () => {
    history.push(`/game-details/${game.id}`);
  };

  return (
    <Paper onClick={OpenGameDetails} className={classes.container}>
      <img src={`https://img.youtube.com/vi/${imageId}/maxresdefault.jpg `} alt={game.title} />
    </Paper>
  );
};

SalesCard.propTypes = {
  classes: PropTypes.object.isRequired,
  game: PropTypes.object,
};

export default withStyles(styles)(SalesCard);
