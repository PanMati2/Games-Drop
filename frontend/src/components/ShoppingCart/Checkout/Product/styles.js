const styles = () => ({
  products: {
    height: '151px',
    display: 'grid',
    gridTemplateColumns: '4fr 1fr 1fr 1fr 1fr',
    justifyContent: 'center',
    border: '1px solid #3D3D3D',
    borderRadius: '5px',
  },
  cover: {
    display: 'flex',
    alignItems: 'center',
    borderRight: '1px solid #3D3D3D',
    '& img': {
      width: '95px',
      height: '130px',
      margin: '10px',
    },
  },
  platform: {
    borderRight: '1px solid #3D3D3D',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
  },
  quantity: {
    borderRight: '1px solid #3D3D3D',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
  },
  subtotal: {
    borderRight: '1px solid #3D3D3D',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
  },
  remove: {
    borderRight: '1px solid #3D3D3D',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
  },
  removeIcon: {
    fontSize: '2.5rem',
    cursor: 'pointer',
  },
});

export default styles;
