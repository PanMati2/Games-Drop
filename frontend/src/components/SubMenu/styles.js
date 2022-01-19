const styles = (theme) => ({
  container: {
    display: 'flex',
    justifyContent: 'space-between',
    width: '1150px',
    marginTop: '30px',
    color: 'white',
    '& a': {
      color: 'white',
    },
    '& a:hover': {
      color: theme.palette.primary.main,
    },
    [theme.breakpoints.down('md')]: {
      width: '900px',
    },
    [theme.breakpoints.down('sm')]: {
      width: '500px',
    },
    [theme.breakpoints.down('xs')]: {
      width: '400px',
      flexDirection: 'column',
      alignItems: 'center',
    },
  },
});

export default styles;
