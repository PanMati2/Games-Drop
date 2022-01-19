import PropTypes from 'prop-types';
import { withStyles } from '@material-ui/core/styles';
import ArrowLeftIcon from '@material-ui/icons/ArrowLeft';
import ArrowRightIcon from '@material-ui/icons/ArrowRight';

export const Arrow = ({ onClick, direction }) => {
  return direction === 'next' ? (
    <StyledArrowForwardIosIcon className="slick-next" onClick={onClick} />
  ) : (
    <StyledArrowBackIosIcon className="slick-prev" onClick={onClick} />
  );
};

export const StyledArrowForwardIosIcon = withStyles({
  root: {
    fill: 'white',
    fontSize: '120px',
  },
})(ArrowRightIcon);

export const StyledArrowBackIosIcon = withStyles({
  root: {
    fill: 'white',
    fontSize: '120px',
    zIndex: '999',
  },
})(ArrowLeftIcon);

Arrow.propTypes = {
  onClick: PropTypes.func,
  direction: PropTypes.string,
};
