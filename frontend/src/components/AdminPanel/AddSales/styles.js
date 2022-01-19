const styles = (theme) => ({
  button: {
    width: '200px',
    marginTop: theme.spacing(1),
  },
  formContainer: {
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    justifyContent: 'center',

    '& .MuiInputBase-root': {
      width: '35ch',
      margin: '15px 0 15px 0',
    },
  },
  paper: {
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    justifyContent: 'center',
    marginTop: '100px',
    width: '500px',
    minHeight: '390px',
  },
  helperText: {
    color: 'red',
    width: '100%',
    paddingLeft: '14px',
  },
  text: {
    marginBottom: '50px',
  },
});

export default styles;
