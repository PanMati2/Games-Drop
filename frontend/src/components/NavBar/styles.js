const styles = (theme) => ({
  container: {
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    height: '100px',
    background: '#243040',
  },
  wrapper: {
    maxWidth: '1150px',
    display: 'flex',
    flexGrow: 1,
    justifyContent: 'space-between',
  },
  grow: {
    flexGrow: 1,
  },
  gamepadIcon: {
    width: '45px',
    height: '45px',
  },
  title: {
    display: 'none',
    textTransform: 'uppercase',
    [theme.breakpoints.up('sm')]: {
      display: 'block',
    },
  },
  navbarIcons: {
    width: '40px',
    height: '40px',
    marginLeft: '10px',
    color: 'white',
  },
  logo: {
    display: 'flex',
    alignItems: 'center',
    cursor: 'pointer',
    color: 'white',
  },
  sectionDesktop: {
    display: 'none',
    [theme.breakpoints.up('md')]: {
      display: 'flex',
    },
  },
  sectionMobile: {
    display: 'flex',
    [theme.breakpoints.up('md')]: {
      display: 'none',
    },
  },
  menuIcons: {
    color: '#3D3D3D',
  },
  button: {
    margin: '10px',
    height: '50px',
  },
});

export default styles;
