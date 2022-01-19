const styles = (theme) => ({
  paper: {
    padding: '2px 4px',
    display: 'flex',
    alignItems: 'center',
    [theme.breakpoints.down('xl')]: {
      marginLeft: theme.spacing(3),
      width: '600px',
    },
    [theme.breakpoints.down('md')]: {
      marginLeft: theme.spacing(3),
      width: '300px',
    },
  },
  input: {
    marginLeft: theme.spacing(1),
    flex: 1,
  },
  iconButton: {
    padding: 10,
  },
  divider: {
    height: 28,
    margin: 4,
  },
});

export default styles;
