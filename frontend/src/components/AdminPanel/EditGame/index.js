import React from 'react';
import PropTypes from 'prop-types';
import { Typography, withStyles } from '@material-ui/core';
import styles from './styles';

const EditGame = ({ classes }) => {
  return (
    <div className={classes.container}>
      <Typography>Edit</Typography>
    </div>
  );
};

EditGame.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(EditGame);
