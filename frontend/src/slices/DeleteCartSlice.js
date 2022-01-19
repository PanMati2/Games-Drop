import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import api from 'api';

export const deleteCart = createAsyncThunk(
  'DeleteCartSlice/deleteCart',
  async ({ gameId }, thunkAPI) => {
    try {
      let res;
      res = await api.deleteCart({ gameId });
      return { ...res.data, gameId: gameId };
    } catch (error) {
      return thunkAPI.rejectWithValue(error.response.data.errors);
    }
  }
);

export const DeleteCartSlice = createSlice({
  name: 'DeleteCartSlices',
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
    [deleteCart.pending]: (state) => {
      state.isLoading = true;
      state.isError = false;
      state.errorMessage = '';
    },
    [deleteCart.fulfilled]: (state, { payload }) => {
      state.gameId = payload.gameId;
      state.isSuccess = true;
      state.isLoading = false;
    },
    [deleteCart.rejected]: (state, { payload }) => {
      state.isError = true;
      state.isLoading = false;
      state.errorMessage = payload;
    },
  },
});

export const { clearState } = DeleteCartSlice.actions;

export default DeleteCartSlice.reducer;
