import { createSlice } from '@reduxjs/toolkit';

export const SearchSlice = createSlice({
  name: 'SearchSlices',
  initialState: {
    searchValue: '',
  },
  reducers: {
    setSearchValue: (state, data) => {
      state.searchValue = data.payload;
    },
  },
});

export const { setSearchValue } = SearchSlice.actions;

export default SearchSlice.reducer;
