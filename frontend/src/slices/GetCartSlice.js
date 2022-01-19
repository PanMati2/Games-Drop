import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import api from 'api';

export const getCart = createAsyncThunk('getGamesSlice/getCart', async (thunkAPI) => {
  try {
    let res;
    res = await api.getCart();
    return {
      ...res.data,
      games: [...res.data.cartItems],
    };
  } catch (error) {
    return thunkAPI.rejectWithValue(error.response.data.errors);
  }
});

export const GetCartSlice = createSlice({
  name: 'GetCartSlices',
  initialState: {
    isLoading: false,
    isSuccess: false,
    isError: false,
    games: [],
  },
  reducers: {
    clearState: (state) => {
      state.isError = false;
      state.isLoading = false;
      state.isSuccess = false;
    },
  },
  extraReducers: {
    [getCart.pending]: (state) => {
      state.isLoading = true;
      state.isError = false;
      state.errorMessage = '';
    },
    [getCart.fulfilled]: (state, { payload }) => {
      state.isSuccess = true;
      state.isLoading = false;
      state.games = payload.games;
    },
    [getCart.rejected]: (state, { payload }) => {
      state.isError = true;
      state.isLoading = false;
      state.errorMessage = payload;
    },
  },
});

export const { clearState } = GetCartSlice.actions;

export default GetCartSlice.reducer;
