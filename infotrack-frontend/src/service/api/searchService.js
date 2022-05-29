import axios from '@/axios'
export async function getSearch(){
  return axios.get('Search/data');
}
export async function getResults(id){
  return axios.get('Search/data/' + id);
}