import React from 'react';
import PropTypes from 'prop-types';
import { Link, Typography, withStyles } from '@material-ui/core';
import styles from './styles';

const SubMenu = ({ classes }) => {
  return (
    <div className={classes.container}>
      <Link underline="none" href="/pc">
        <Typography variant="subtitle1" color="initial">
          PC
        </Typography>
      </Link>
      <Link underline="none" href="/xbox">
        <Typography variant="subtitle1" color="initial">
          XBOX
        </Typography>
      </Link>
      <Link underline="none" href="/ps">
        <Typography variant="subtitle1" color="initial">
          PLAYSTATION
        </Typography>
      </Link>
      <Link underline="none" href="/nintendo">
        <Typography variant="subtitle1" color="initial">
          NINTENDO
        </Typography>
      </Link>
    </div>
  );
};

SubMenu.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(SubMenu);
