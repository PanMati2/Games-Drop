import { configureStore } from '@reduxjs/toolkit';
import LoginReducer from 'slices/LoginSlice';
import RegisterReducer from 'slices/RegisterSlice';
import AddGameReducer from 'slices/AddGameSlice';
import GetGamesReducer from 'slices/GetGamesSlice';
import SearchReducer from 'slices/SearchSlice';
import AddToCartReducer from 'slices/AddToCartSlice';
import GetCartSliceReducer from 'slices/GetCartSlice';
import TotalPriceReducer from 'slices/TotalPriceSlice';
import DeleteCartReducer from 'slices/DeleteCartSlice';
import AddSalesReducer from 'slices/AddSalesSlice';

export default configureStore({
  reducer: {
    LoginSlice: LoginReducer,
    RegisterSlice: RegisterReducer,
    AddGameSlice: AddGameReducer,
    GetGamesSlice: GetGamesReducer,
    SearchSlice: SearchReducer,
    AddToCartSlice: AddToCartReducer,
    GetCartSlice: GetCartSliceReducer,
    TotalPriceSlice: TotalPriceReducer,
    DeleteCartSlice: DeleteCartReducer,
    AddSalesSlice: AddSalesReducer,
  },
});
