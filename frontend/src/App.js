import React from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import { ThemeProvider, CssBaseline } from '@material-ui/core';
import HomePage from 'pages/HomePage';
import LoginPage from 'pages/LoginPage';
import theme from 'theme';
import RegisterPage from 'pages/RegisterPage';
import CheckoutPage from 'pages/CheckoutPage';
import PaymentPage from 'pages/PaymentPage';
import ResultPages from 'pages/ResultPages';
import PCGamesPage from 'pages/PCGamesPage';
import AdminPanelPage from 'pages/AdminPanelPage';
import GameDetailsPage from 'pages/GameDetailsPage';
import XboxGamesPage from 'pages/XboxGamesPage';
import PSGamesPage from 'pages/PSGamesPage';
import NintendoGamesPage from 'pages/NintendoGamesPage';

const App = () => {
  return (
    <div>
      <ThemeProvider theme={theme}>
        <CssBaseline />
        <Router>
          <Switch>
            <Route exact path="/" component={HomePage}></Route>
            <Route exact path="/login" component={LoginPage}></Route>
            <Route exact path="/register" component={RegisterPage}></Route>
            <Route exact path="/checkout" component={CheckoutPage}></Route>
            <Route exact path="/payment" component={PaymentPage}></Route>
            <Route exact path="/result" component={ResultPages}></Route>
            <Route exact path="/pc" component={PCGamesPage}></Route>
            <Route exact path="/xbox" component={XboxGamesPage}></Route>
            <Route path="/admin-panel" component={AdminPanelPage}></Route>
            <Route path="/game-details" component={GameDetailsPage}></Route>
            <Route path="/ps" component={PSGamesPage}></Route>
            <Route path="/nintendo" component={NintendoGamesPage}></Route>
          </Switch>
        </Router>
      </ThemeProvider>
    </div>
  );
};

export default App;
