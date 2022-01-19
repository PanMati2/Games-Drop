import React from 'react';
import PropTypes from 'prop-types';
import { useHistory } from 'react-router-dom';
import { CheckRoles } from 'helpers/GetRoles';
import {
  withStyles,
  AppBar,
  Toolbar,
  IconButton,
  Typography,
  MenuItem,
  Menu,
  Link,
  Button,
} from '@material-ui/core';
import AccountCircle from '@material-ui/icons/AccountCircle';
import SportsEsportsIcon from '@material-ui/icons/SportsEsports';
import ShoppingCartOutlined from '@material-ui/icons/ShoppingCartOutlined';
import SearchBar from 'components/SearchBar';
import MoreIcon from '@material-ui/icons/MoreVert';
import styles from './styles';
import DashboardIcon from '@material-ui/icons/Dashboard';
import ShoppingCartIcon from '@material-ui/icons/ShoppingCart';
import ExitToAppIcon from '@material-ui/icons/ExitToApp';

const Navbar = ({ classes, position }) => {
  const isLoggedIn = localStorage.getItem('accessToken');
  const userRole = CheckRoles('Admin');
  const history = useHistory();
  const [anchorEl, setAnchorEl] = React.useState(null);
  const [mobileMoreAnchorEl, setMobileMoreAnchorEl] = React.useState(null);

  const isMenuOpen = Boolean(anchorEl);
  const isMobileMenuOpen = Boolean(mobileMoreAnchorEl);

  const handleMobileMenuOpen = (event) => {
    setMobileMoreAnchorEl(event.currentTarget);
  };

  const handleProfileMenuOpen = (event) => {
    setAnchorEl(event.currentTarget);
  };

  const handleMenuClose = () => {
    setAnchorEl(null);
  };

  const handleMobileMenuClose = () => {
    setMobileMoreAnchorEl(null);
  };

  const onLogOut = () => {
    localStorage.clear();
    history.push('/');
    window.location.reload();
  };

  const menuId = 'primary-search-account-menu';
  const renderMenu = (
    <Menu
      anchorEl={anchorEl}
      anchorOrigin={{ vertical: 'top', horizontal: 'right' }}
      id={menuId}
      keepMounted
      transformOrigin={{ vertical: 'top', horizontal: 'right' }}
      open={isMenuOpen}
      onClose={handleMenuClose}
    >
      {userRole && (
        <Link underline="none" href="/admin-panel/add">
          <MenuItem className={classes.menuIcons} onClick={handleMenuClose}>
            Zarządzaj
          </MenuItem>
        </Link>
      )}
      <Link underline="none" href="/checkout">
        <MenuItem className={classes.menuIcons} onClick={handleMenuClose}>
          Koszyk
        </MenuItem>
      </Link>
      <MenuItem onClick={onLogOut}>Wyloguj się</MenuItem>
    </Menu>
  );
  const mobileMenuId = 'primary-search-account-menu-mobile';
  const renderMobileMenu = (
    <Menu
      anchorEl={mobileMoreAnchorEl}
      anchorOrigin={{ vertical: 'top', horizontal: 'right' }}
      id={mobileMenuId}
      keepMounted
      transformOrigin={{ vertical: 'top', horizontal: 'right' }}
      open={isMobileMenuOpen}
      onClose={handleMobileMenuClose}
    >
      {isLoggedIn ? (
        <div>
          {userRole && (
            <Link underline="none" href="/admin-panel/add">
              <MenuItem className={classes.menuIcons}>
                <IconButton edge="end" aria-label="profile" aria-haspopup="true" color="inherit">
                  <DashboardIcon />
                </IconButton>
                <p>Zarządzaj</p>
              </MenuItem>
            </Link>
          )}
          <Link underline="none" href="/checkout">
            <MenuItem className={classes.menuIcons}>
              <IconButton
                edge="end"
                aria-label="shopping cart"
                aria-haspopup="true"
                color="inherit"
              >
                <ShoppingCartIcon />
              </IconButton>
              <p>Koszyk</p>
            </MenuItem>
          </Link>
          <MenuItem onClick={onLogOut} className={classes.menuIcons}>
            <IconButton edge="end" aria-label="logout" aria-haspopup="true" color="inherit">
              <ExitToAppIcon />
            </IconButton>
            <p>Wyloguj się</p>
          </MenuItem>
        </div>
      ) : (
        <Link underline="none" href="/login">
          <MenuItem className={classes.menuIcons}>
            <IconButton edge="end" aria-label="shopping cart" aria-haspopup="true" color="inherit">
              <AccountCircle />
            </IconButton>
            <p>Zaloguj się</p>
          </MenuItem>
        </Link>
      )}
    </Menu>
  );

  return (
    <div>
      <AppBar position={position} className={classes.container} elevation={0}>
        <Toolbar className={classes.wrapper}>
          <Link href="/" underline="none" className={classes.logo}>
            <SportsEsportsIcon className={classes.gamepadIcon} />
            <Typography className={classes.title} variant="h5" noWrap>
              Games Drop
            </Typography>
          </Link>
          <div className={classes.searchBar}>
            <SearchBar />
          </div>
          <div className={classes.sectionDesktop}>
            {isLoggedIn ? (
              <IconButton
                edge="end"
                aria-label="account of current user"
                aria-controls={menuId}
                aria-haspopup="true"
                onClick={handleProfileMenuOpen}
                color="inherit"
              >
                <AccountCircle className={classes.navbarIcons} />
              </IconButton>
            ) : (
              <Link href="/login" underline="none">
                <Button size="small" className={classes.button} variant="contained" color="primary">
                  Zaloguj się
                </Button>
              </Link>
            )}

            <Link underline="none" href="/checkout">
              <IconButton
                edge="end"
                aria-label="shopping cart"
                aria-haspopup="true"
                color="inherit"
              >
                <ShoppingCartOutlined className={classes.navbarIcons} />
              </IconButton>
            </Link>
          </div>
          <div className={classes.sectionMobile}>
            <IconButton
              aria-label="show more"
              aria-controls={mobileMenuId}
              aria-haspopup="true"
              onClick={handleMobileMenuOpen}
              color="inherit"
            >
              <MoreIcon />
            </IconButton>
          </div>
        </Toolbar>
      </AppBar>
      {renderMobileMenu}
      {renderMenu}
    </div>
  );
};

Navbar.propTypes = {
  classes: PropTypes.object,
  position: PropTypes.string,
};

export default withStyles(styles)(Navbar);
