import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import api from 'api';

export const getGames = createAsyncThunk('getGamesSlice/getGames', async (thunkAPI) => {
  try {
    let res;
    res = await api.getGames();
    return {
      ...res.data,
      games: [...res.data],
    };
  } catch (error) {
    return thunkAPI.rejectWithValue(error.response.data.errors);
  }
});

export const GetGamesSlice = createSlice({
  name: 'GetGamesSlices',
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
    [getGames.pending]: (state) => {
      state.isLoading = true;
      state.isError = false;
      state.errorMessage = '';
    },
    [getGames.fulfilled]: (state, { payload }) => {
      state.isSuccess = true;
      state.isLoading = false;
      state.games = payload.games;
    },
    [getGames.rejected]: (state, { payload }) => {
      state.isError = true;
      state.isLoading = false;
      state.errorMessage = payload;
    },
  },
});

export const { clearState } = GetGamesSlice.actions;

export default GetGamesSlice.reducer;
