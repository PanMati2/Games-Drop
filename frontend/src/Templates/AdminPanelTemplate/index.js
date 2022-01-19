import React from 'react';
import { useSelector } from 'react-redux';
import PropTypes from 'prop-types';
import Menu from 'components/AdminPanel/Menu';
import { withStyles } from '@material-ui/core';
import styles from './styles';
import { Route } from 'react-router-dom';
import NavBar from 'components/NavBar';
import AddGame from 'components/AdminPanel/AddGame';
import EditGame from 'components/AdminPanel/EditGame';
import SearchResult from 'components/SearchResult';
import AddSales from '../../components/AdminPanel/AddSales';

const ProfileComponent = ({ classes }) => {
  const searchValue = useSelector((state) => state.SearchSlice.searchValue);
  return (
    <div className={classes.container}>
      <NavBar position="absolute" />
      {searchValue.length > 0 ? (
        <SearchResult />
      ) : (
        <>
          <div className={classes.leftBox}>
            <Menu />
          </div>
          <div className={classes.rightBox}>
            <Route path="/admin-panel/add" component={AddGame}></Route>
            <Route path="/admin-panel/sales" component={AddSales}></Route>
            <Route path="/admin-panel/edit" component={EditGame}></Route>
          </div>
        </>
      )}
    </div>
  );
};

ProfileComponent.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(ProfileComponent);
