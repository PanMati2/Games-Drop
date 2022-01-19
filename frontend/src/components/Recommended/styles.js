const styles = (theme) => ({
  container: {
    display: 'grid',
    gridTemplateColumns: '1fr 1fr 1fr',
    justifyItems: 'center',
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
