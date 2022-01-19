import React from 'react';
import { useSelector } from 'react-redux';
import { Grid } from '@material-ui/core';
import PropTypes from 'prop-types';
import Navbar from 'components/NavBar';
import { withStyles } from '@material-ui/core';
import styles from './styles';
import SearchResult from 'components/SearchResult';

const HomeTemplate = ({ children, classes }) => {
  const searchValue = useSelector((state) => state.SearchSlice.searchValue);

  return (
    <div>
      <Navbar position="fixed" />
      <Grid
        className={classes.grid}
        container
        direction="column"
        justify="center"
        alignItems="center"
      >
        {searchValue.length > 0 ? <SearchResult /> : [children]}
      </Grid>
    </div>
  );
};

HomeTemplate.propTypes = {
  children: PropTypes.array,
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(HomeTemplate);
