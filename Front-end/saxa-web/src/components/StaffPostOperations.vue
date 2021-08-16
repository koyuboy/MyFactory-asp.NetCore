<template>
<nav class="navbar navbar-dark bg-dark">
    <div class="container-fluid">
  <router-link to="/shome" class="navbar-brand">Home</router-link>
  <router-link to="/postProduct" class="nav-link">Post Product</router-link>
  <router-link to="/postProductTree" class="nav-link">Post Product Tree</router-link>
  <router-link to="/postMachines" class="nav-link">Post Machines</router-link>
  <router-link to="/" class="navbar-brand">Exit</router-link>
  </div>
</nav>

<div class="d-flex justify-content-center mt-5">
  <form class="row g-2 w-25">
    <label for="OperationName">Operation Name</label>
    <input v-model="operationName" id="OperationName"/>
    <br>
    <label for="ProductType">Product Type</label>
    <input v-model="productType" id="ProductType"/>
    <br>
    <button @click="addOperations" class="btn btn-success w-50">Add</button>
  </form>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  name: 'staff-post-operations',
  data () {
    return {
      operationName: '',
      productType: ''
    }
  },
  props: {
    apiAddr: String
  },
  methods: {
    addOperations () {
      axios.post(this.apiAddr, {
        operationName: this.operationName,
        productType: this.productType
      })
        .then(response => {
          this.response = response.data
          alert('Successful')
        })
    }
  }
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
