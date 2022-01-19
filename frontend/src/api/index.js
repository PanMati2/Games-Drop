import axios from 'axios';

const baseUrl = 'http://localhost:8080/api';

axios.interceptors.request.use(
  (config) => {
    const accessToken = localStorage.getItem('accessToken');
    if (accessToken) {
      config.headers.Authorization = `Bearer ${accessToken}`;
    }
    return config;
  },
  (error) => {
    Promise.reject(error);
  }
);

const api = {
  signup: (body) => {
    return axios.post(`${baseUrl}/auth/register`, body);
  },
  login: (body) => {
    return axios.post(`${baseUrl}/auth/login`, body);
  },
  addGame: (body) => {
    return axios.post(`${baseUrl}/games`, body);
  },
  getGames: () => {
    return axios.get(`${baseUrl}/games`);
  },
  getCart: () => {
    return axios.get(`${baseUrl}/cart/items`);
  },
  addToCart: (body) => {
    return axios.post(`${baseUrl}/cart/items`, body);
  },
  deleteCart: (body) => {
    return axios.delete(`${baseUrl}/cart/items`, { data: body });
  },
  addSales: (body) => {
    return axios.post(`${baseUrl}/games/sales`, body);
  },
};
export default api;
