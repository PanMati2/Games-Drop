import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import api from 'api';

export const addGame = createAsyncThunk(
  'AddGameSlice/addGame',
  async (
    { categoryId, platformId, title, price, recommended, description, coverUrl, trailerUrl },
    thunkAPI
  ) => {
    try {
      let res;
      res = await api.addGame({
        categoryId,
        platformId,
        title,
        price,
        recommended,
        description,
        coverUrl,
        trailerUrl,
      });
      return {
        ...res.data,
        categoryId: categoryId,
        platformId: platformId,
        title: title,
        price: price,
        recommended: recommended,
        description: description,
        coverUrl: coverUrl,
        trailerUrl: trailerUrl,
      };
    } catch (error) {
      return thunkAPI.rejectWithValue(error.response.data.errors);
    }
  }
);

export const AddGameSlice = createSlice({
  name: 'AddGameSlices',
  initialState: {
    isLoading: false,
    isSuccess: false,
    isError: false,
    errorMessage: '',
    categoryId: '',
    platformId: '',
    title: '',
    price: '',
    recommended: false,
    description: '',
    coverUrl: '',
    trailerUrl: '',
  },
  reducers: {
    clearState: (state) => {
      state.isError = false;
      state.isLoading = false;
      state.isSuccess = false;
    },
  },
  extraReducers: {
    [addGame.pending]: (state) => {
      state.isLoading = true;
      state.isError = false;
      state.errorMessage = '';
    },
    [addGame.fulfilled]: (state, { payload }) => {
      state.categoryId = payload.categoryId;
      state.platformId = payload.platformId;
      state.title = payload.title;
      state.price = payload.price;
      state.recommended = payload.recommended;
      state.description = payload.description;
      state.coverUrl = payload.coverUrl;
      state.trailerUrl = payload.trailerUrl;
      state.isSuccess = true;
      state.isLoading = false;
    },
    [addGame.rejected]: (state, { payload }) => {
      state.isError = true;
      state.isLoading = false;
      state.errorMessage = payload;
    },
  },
});

export const { clearState } = AddGameSlice.actions;

export default AddGameSlice.reducer;
