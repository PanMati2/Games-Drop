import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import api from 'api';

export const addSales = createAsyncThunk(
  'AddSalesSlice/addSales',
  async ({ gameId, percentDiscount }, thunkAPI) => {
    const validFrom = '2021-03-27T17:09:02.328Z';
    const validTo = '2023-05-27T17:09:02.328Z';
    try {
      let res;
      res = await api.addSales({
        gameId,
        validFrom,
        validTo,
        percentDiscount,
      });
      return {
        ...res.data,
        gameId: gameId,
        validFrom: validFrom,
        validTo: validTo,
        percentDiscount: percentDiscount,
      };
    } catch (error) {
      return thunkAPI.rejectWithValue(error.response.data.errors);
    }
  }
);

export const AddSalesSlice = createSlice({
  name: 'AddSalesSlices',
  initialState: {
    isLoading: false,
    isSuccess: false,
    isError: false,
    errorMessage: '',
    gameId: '',
    validFrom: '',
    validTo: '',
    percentDiscount: '',
  },
  reducers: {
    clearState: (state) => {
      state.isError = false;
      state.isLoading = false;
      state.isSuccess = false;
    },
  },
  extraReducers: {
    [addSales.pending]: (state) => {
      state.isLoading = true;
      state.isError = false;
      state.errorMessage = '';
    },
    [addSales.fulfilled]: (state, { payload }) => {
      state.isSuccess = true;
      state.isLoading = false;
      state.gameId = payload.gameId;
      state.validFrom = payload.validFrom;
      state.validTo = payload.validTo;
      state.percentDiscount = payload.percentDiscount;
    },
    [addSales.rejected]: (state, { payload }) => {
      state.isError = true;
      state.isLoading = false;
      state.errorMessage = payload;
    },
  },
});

export const { clearState } = AddSalesSlice.actions;

export default AddSalesSlice.reducer;
