const styles = (theme) => ({
  container: {
    display: 'flex',
    margin: '100px 0 100px 0',
    maxWidth: '1150px',
    [theme.breakpoints.down('md')]: {
      flexDirection: 'column',
    },
  },
  leftBox: {
    width: '100vw',
    display: 'flex',
    justifyContent: 'center',
    '& img': {
      width: '496px',
      height: '700px',
    },
    [theme.breakpoints.down('md')]: {
      '& img': {
        width: '296px',
        height: '500px',
      },
    },
  },
  rightBox: {
    maxWidth: '100vw',
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    padding: '20px',
    background: '#141b24',
    color: 'white',
  },
  informations: {
    width: '100%',
  },
  heading: {
    display: 'flex',
    justifyContent: 'space-between',
    width: '100%',
    [theme.breakpoints.down('md')]: {
      flexDirection: 'column',
      textAlign: 'center',
    },
  },
  description: {
    marginTop: '50px',
    [theme.breakpoints.down('md')]: {
      textAlign: 'center',
    },
  },
  basket: {
    border: `solid 1px ${theme.palette.secondary.main}`,
  },
  button: {
    textAlign: 'right',
    marginTop: '10px',
  },
  trailer: {
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    flexDirection: 'column',
    [theme.breakpoints.down('md')]: {
      display: 'flex',
      justifyContent: 'center',
      alignItems: 'center',
      flexDirection: 'column',
    },
  },
});

export default styles;
