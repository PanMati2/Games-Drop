const styles = (theme) => ({
  container: {
    width: '1050px',
    margin: '80px 0 30px 0',
    textTransform: 'uppercase',
    textAlign: 'center',
    [theme.breakpoints.down('md')]: {
      width: '900px',
    },
    [theme.breakpoints.down('sm')]: {
      width: '500px',
    },
    [theme.breakpoints.down('xs')]: {
      width: '400px',
    },
  },
  header: {
    display: 'flex',
    justifyContent: 'space-evenly',
    alignItems: 'center',
    '& MuiSelect-root MuiSelect-select MuiSelect-selectMenu MuiSelect-filled MuiInputBase-input MuiFilledInput-input':
      {
        color: 'white',
        background: 'white',
      },
  },
  formControl: {
    margin: theme.spacing(1),
    minWidth: 250,
  },
  inputColor: {
    color: 'white',
  },
  divider: {
    background: 'white',
  },
  games: {
    display: 'grid',
    gridTemplateColumns: '1fr 1fr 1fr',
    width: '1150px',
    height: '900px',

    [theme.breakpoints.down('md')]: {
      width: '900px',
    },
    [theme.breakpoints.down('sm')]: {
      width: '500px',
    },
    [theme.breakpoints.down('xs')]: {
      justifyItems: 'center',
      gridTemplateColumns: '1fr',
      width: '400px',
    },
  },
  loadingCircularContainer: {
    gridColumnStart: '2',
    margin: '0 auto',
  },
});

export default styles;
