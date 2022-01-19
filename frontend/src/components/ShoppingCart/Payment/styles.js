const styles = (theme) => ({
  container: {
    width: '70%',
    minHeight: '300px',
    background: '#141b24',
    margin: '100px 0 100px 0',
    borderRadius: '5px',
    boxShadow: '0 2px 10px 0px black',
    display: 'flex',
    [theme.breakpoints.down('sm')]: {
      flexDirection: 'column',
    },
  },
  divider: {
    height: '300px',
    width: '2px',
    background: theme.palette.primary.main,
    [theme.breakpoints.down('sm')]: {
      display: 'none',
    },
  },
  billing: {
    width: '100%',
    display: 'flex',
    flexDirection: 'column',
    padding: '30px 0px 0px 30px',
  },
  billingDetails: {
    paddingTop: '30px',
  },
  paymentMethod: {
    width: '100%',
    display: 'flex',
    padding: '30px 0px 0px 30px',
  },
  button: {
    display: 'flex',
    justifyContent: 'flex-end',
    padding: '15px',
  },
  formControl: {
    width: '100%',
    '& .MuiFormGroup-root': {
      height: '100%',
    },
  },
});

export default styles;
