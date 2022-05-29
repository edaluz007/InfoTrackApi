<template>
<div>
  <input
  :value="text"
  @input="event => text = event.target.value">
    <button>SEARCH</button>
</div>

</template>

<script>
import { GetSearch, GetResults } from "../../services/api/searchService";
export default {
  data() {
    return {
      searchText: "",
      searchValues: []
    };
  },  
    save() {
        GetResults(this.$route.params.id, {
          search: this.searchText
        }) .then((res) => console.log(res))
          .catch((err) => console.log(err.res));
  },
  created() {
    GetSearch(this.$route.params.id)
      .then((res) => {
        this.searchValues = res.data.data;
      })
      .catch((err) => console.log(err));
  },
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
