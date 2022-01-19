import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import api from 'api';

export const AddToCart = createAsyncThunk(
  'AddToCartSlice/AddToCart',
  async ({ gameId }, thunkAPI) => {
    try {
      let res;
      res = await api.addToCart({ gameId });
      return { ...res.data, gameId: gameId };
    } catch (error) {
      return thunkAPI.rejectWithValue(error.response.data.errors);
    }
  }
);

export const AddToCartSlice = createSlice({
  name: 'AddToCartSlices',
  initialState: {
    gameId: '',
    isLoading: false,
    isSuccess: false,
    isError: false,
    errorMessage: '',
  },
  reducers: {
    clearState: (state) => {
      state.isError = false;
      state.isLoading = false;
      state.isSuccess = false;
    },
  },
  extraReducers: {
    [AddToCart.pending]: (state) => {
      state.isLoading = true;
      state.isError = false;
      state.errorMessage = '';
    },
    [AddToCart.fulfilled]: (state, { payload }) => {
      state.gameId = payload.gameId;
      state.isSuccess = true;
      state.isLoading = false;
    },
    [AddToCart.rejected]: (state, { payload }) => {
      state.isError = true;
      state.isLoading = false;
      state.errorMessage = payload;
    },
  },
});

export const { clearState } = AddToCartSlice.actions;

export default AddToCartSlice.reducer;
