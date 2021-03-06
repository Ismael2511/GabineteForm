import Vue from "vue";
import axios from "axios";
import VueAxios from "vue-axios";
// import JwtService from "@/common/jwt.service";
import { API_URL } from "@/common/config";
// import jwtService from "./jwt.service";

const ApiService = {
  init() {
    Vue.use(VueAxios, axios);
    Vue.axios.defaults.baseURL = API_URL;
    Vue.axios.defaults.timeout=30000;
   // setHeader()
  },
  addAuth(){
    setHeader("")
  },
  setHeader(obj){
    setHeader(obj)
  },
  query(resource, params) {
    return axios.get(resource, params).catch(handleError);
  },

  get(resource, slug = "") {
    return axios.get(`${resource}/${slug}`).catch(handleError);
  },
  getId(source,id){
    return axios.get(`${source}/${id}`).catch(handleError);
  },
  post(source, data) {
    return axios.post(source,data)
  },

  update(resource, slug, params) {
    return axios.put(`${resource}/${slug}`, params).catch(handleError);
  },

  put(resource, params) {
    return axios.put(`${resource}`, params);
  },

  delete(resource) {
    return axios.delete(resource).catch(handleError);
  },
  getContacts() {
    const url = `${API_URL}/Miembro/GetMember`;
    return axios.get(url).then(response => response.data);
  },
};


function setHeader(obj){ 
    // Vue.axios.defaults.headers.common["token"] = JwtService.getToken();
    Vue.axios.defaults.headers.common["type"] ="WEB";
    Vue.axios.defaults.headers.common["version"] ="1.0";
    if (typeof obj === 'object') {
      for (let el in obj) {
        Vue.axios.defaults.headers.common[el] = obj[el];
      }
    }
}

function handleError(error) {
  return new Promise(() =>{
      if (error.response.status === 401) {
        // JwtService.destroyToken()
        // jwtService.destroyUser();
        location.reload()
      }else {
        throw new Error(`[RWV] ApiService ${error}`);
      }
  });
}

export default ApiService;