import React from 'react';
import PropTypes from 'prop-types';
import { useHistory } from 'react-router-dom';
import { Divider, List, ListItem, ListItemText, withStyles, Link } from '@material-ui/core';
import { Avatar, Typography } from '@material-ui/core';
import AddCircleIcon from '@material-ui/icons/AddCircle';
import EditIcon from '@material-ui/icons/Edit';
import ExitToAppIcon from '@material-ui/icons/ExitToApp';
import AddToPhotosIcon from '@material-ui/icons/AddToPhotos';
import styles from './styles';

const Menu = ({ classes }) => {
  const userName = localStorage.getItem('firstName');
  const history = useHistory();

  const onLogOut = () => {
    localStorage.clear();
    history.push('/');
    window.location.reload();
  };

  return (
    <>
      <div className={classes.container}>
        <div className={classes.user}>
          <Avatar className={classes.avatar}>{userName.substring(0, 1)}</Avatar>
          <Typography>{userName}</Typography>
        </div>
        <List>
          <Divider />
          <Link underline="none" color="inherit" href="/admin-panel/add">
            <ListItem button>
              <AddCircleIcon className={classes.icon} />
              <ListItemText>Dodaj gre</ListItemText>
            </ListItem>
          </Link>
          <Divider />
          <Link underline="none" color="inherit" href="/admin-panel/edit">
            <ListItem button>
              <EditIcon className={classes.icon} />
              <ListItemText>Edytuj gre</ListItemText>
            </ListItem>
          </Link>
          <Divider />
          <Link underline="none" color="inherit" href="/admin-panel/sales">
            <ListItem button>
              <AddToPhotosIcon className={classes.icon} />
              <ListItemText>Dodaj promocje</ListItemText>
            </ListItem>
          </Link>
          <Divider />
          <Link onClick={onLogOut} underline="none" color="inherit">
            <ListItem button>
              <ExitToAppIcon className={classes.icon} />
              <ListItemText>Wyloguj się</ListItemText>
            </ListItem>
          </Link>
          <Divider />
        </List>
      </div>
    </>
  );
};

Menu.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Menu);
