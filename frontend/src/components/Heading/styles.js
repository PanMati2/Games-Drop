const styles = (theme) => ({
  bigContainer: {
    width: '1150px',
    margin: '30px 0 30px 0',
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
  smallContainer: {
    width: '500px',
    margin: '30px 0 30px 0',
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
  divider: {
    background: 'white',
  },
});

export default styles;
