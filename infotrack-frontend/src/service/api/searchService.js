import axios from '@/axios'
export async function getAccountTypes(){
  return axios.get('Search/data');
}
export async function getAccountType(id){
  return axios.get('Search/data/' + id);
}