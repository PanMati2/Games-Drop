import { createSlice } from '@reduxjs/toolkit';

export const TotalPriceSlice = createSlice({
  name: 'TotalPriceSlices',
  initialState: {
    totalPrice: 0,
  },
  reducers: {
    setPrice: (state, data) => {
      state.totalPrice += data.payload;
    },
  },
});

export const { setPrice } = TotalPriceSlice.actions;

export default TotalPriceSlice.reducer;
