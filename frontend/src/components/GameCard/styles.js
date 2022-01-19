const styles = (theme) => ({
  container: {
    display: 'flex',
    flexDirection: 'column',
    maxWidth: '250px',
    height: '575px',
    margin: '10px',
  },
  cover: {
    '& img': {
      width: '100%',
      hegith: '100%',
      marginBottom: '5px',
      boxShadow: '0 4px 10px 0px black',
      cursor: 'pointer',
    },
    '& img:hover': {
      background: 'red',
      transform: 'scale(1.1)',
      transitionDuration: '1s',
    },
  },
  details: {
    height: '100%',
    background: '#141b24',
    borderRadius: '5px',
  },
  divider: {
    background: '#3D3D3D',
  },
  title: {
    height: '65%',
    padding: '10px',
  },
  price: {
    display: 'flex',
    justifyContent: 'space-between',
    alignItems: 'center',
    margin: '10px 0 15px 0',
    padding: '0 10px 0 20px',
  },
  basket: {
    border: `solid 1px ${theme.palette.secondary.main}`,
  },
  discount: {
    width: '50px',
    background: '#1ad395',
    textAlign: 'center',
  },
});

export default styles;
