const styles = (theme) => ({
  paper: {
    width: '1150px',
    height: '450px',
    margin: '0px 0 30px 0',
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
  slide: {
    '& .slick-dots li button:before': {
      color: 'white',
    },
  },
  loadingCircularContainer: {
    height: '100%',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
  },
  banner: {
    marginTop: '50px',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    background: '#141b24',
    width: '1150px',
    height: '70px',
    color: 'white',
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
});

export default styles;
