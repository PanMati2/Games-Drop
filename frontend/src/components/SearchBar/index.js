import React from 'react';
import { useDispatch } from 'react-redux';
import { setSearchValue } from 'slices/SearchSlice';
import PropTypes from 'prop-types';
import { withStyles, Paper, InputBase, Divider, IconButton } from '@material-ui/core';
import SearchIcon from '@material-ui/icons/Search';
import styles from './styles';

const SearchBar = ({ classes }) => {
  const dispatch = useDispatch();

  const Search = (e) => {
    dispatch(setSearchValue(e.target.value));
  };

  return (
    <Paper component="form" className={classes.paper}>
      <InputBase onChange={(e) => Search(e)} className={classes.input} placeholder="Szukaj gry" />
      <Divider className={classes.divider} orientation="vertical" />
      <IconButton type="submit" className={classes.iconButton} aria-label="search">
        <SearchIcon />
      </IconButton>
    </Paper>
  );
};

SearchBar.propTypes = {
  classes: PropTypes.object,
};

export default withStyles(styles)(SearchBar);
