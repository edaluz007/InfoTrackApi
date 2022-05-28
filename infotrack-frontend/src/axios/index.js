import Axios from 'axios'
import VueCookies from 'vue-cookies';
import Vue from 'vue'
Vue.use(VueCookies);
let Api = ''
if (process.env.NODE_ENV === 'production') {
    Api = Axios.create({
        baseURL: '/infotrackapi/api/',
    })
}
else {
    Api = Axios.create({
        baseURL: 'https://localhost:5001/api/',
    })
}
export default Api;