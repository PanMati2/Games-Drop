import { createMuiTheme } from '@material-ui/core/styles';

const theme = createMuiTheme({
  overrides: {
    MuiCssBaseline: {
      '@global': {
        body: {
          marginTop: '100px',
          backgroundColor: '#243040',
          color: 'white',
        },
      },
    },
  },
  typography: {
    fontFamily: ['Montserrat', 'sans-serif'].join(','),
    subtitle1: {
      fontSize: '21px',
      fontWeight: 'bold',
    },
    subtitle2: {
      fontSize: '15px',
      fontWeight: 'bold',
    },
  },
});

export default theme;
