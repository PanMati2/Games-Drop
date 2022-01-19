import React from 'react';
import PropTypes from 'prop-types';
import { Divider, withStyles } from '@material-ui/core';
import styles from './styles';

const Heading = ({ classes, title, type }) => {
  return (
    <div className={type === 'small' ? classes.smallContainer : classes.bigContainer}>
      <Divider className={classes.divider} variant="fullWidth" />
      {type === 'big' && <h1>{title}</h1>}
      {type === 'small' && <h2>{title}</h2>}
      <Divider className={classes.divider} />
    </div>
  );
};

Heading.propTypes = {
  classes: PropTypes.object.isRequired,
  title: PropTypes.string,
  type: PropTypes.string,
};

export default withStyles(styles)(Heading);
