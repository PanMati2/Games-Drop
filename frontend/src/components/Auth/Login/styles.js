const styles = (theme) => ({
  button: {
    width: '200px',
    marginTop: theme.spacing(1),
  },
  link: {
    cursor: 'pointer',
  },
  formContainer: {
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    justifyContent: 'center',

    '& .MuiTextField-root': {
      width: '25ch',
      margin: '10px',
    },
  },
  paper: {
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    justifyContent: 'center',
    marginTop: '100px',
    width: '500px',
    height: '400px',
  },
});

export default styles;
