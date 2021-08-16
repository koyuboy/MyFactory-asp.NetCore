<template>

<nav class="navbar navbar-dark bg-dark">
    <div class="container-fluid d-flex flex-row-reverse">
    <router-link to="/" class="nav-link">Exit</router-link>
    <router-link to="/chome" class="nav-link">Home</router-link>
    </div>
</nav>

<div class="p-5">
<table class="table table-dark table-hover">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Order Id</th>
      <th scope="col">Customer Id</th>
      <th scope="col">Order Date</th>
      <th scope="col">Deadline</th>
    </tr>
  </thead>
  <tbody>
    <tr v-for="item in items" :key="item">
      <th scope="row">-></th>
      <td>{{ item.orderId }} </td>
      <td>{{ item.customerId }} </td>
      <td>{{ item.orderDate }} </td>
      <td> {{ item.deadline }} </td>
    </tr>
  </tbody>
</table>
</div>
</template>

<script>
import axios from 'axios'

export default {
  name: 'customer-order',
  data () {
    return {
      /*
      orderId: 0,
      customerId : 0,
      orderDate: '',
      deadline: '',
      */
      items: []
    }
  },
  mounted () {
    axios.get(this.apiAddr).then(response => {
      this.items = response.data
    })
  },
  props: {
    apiAddr: String
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
