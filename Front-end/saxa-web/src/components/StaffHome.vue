<template>
<nav class="navbar navbar-dark bg-dark">
    <div class="container-fluid">
    <router-link to="/postProduct" class="nav-link">Post Product</router-link>
    <router-link to="/postProductTree" class="nav-link">Post Product Tree</router-link>
    <router-link to="/postMachines" class="nav-link">Post Machines</router-link>
    <router-link to="/postOperations" class="nav-link">Post Operations</router-link>
    <router-link to="/" class="navbar-brand">Exit</router-link>
    </div>
</nav>
  <router-view/>

<div class="container p-5">
  <div class="row">
  <div class="col mt-4">
    <table class="table table-dark table-hover">
      <thead>
        <tr>
          <th scope="col">Order Id</th>
          <th scope="col">Customer Id</th>
          <th scope="col">Order Date</th>
          <th scope="col">Deadline</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in siparisItems" :key="item">
          <td>{{ item.orderId }} </td>
          <td>{{ item.customerId }} </td>
          <td>{{ item.orderDate }} </td>
          <td> {{ item.deadline }} </td>
        </tr>
      </tbody>
    </table>
  </div>
  <div class="col mt-4">
    <table class="table table-dark table-hover">
      <thead>
        <tr>
          <th scope="col">WC ID</th>
          <th scope="col">WC Name</th>
          <th scope="col">Is Active</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in workCentersItems" :key="item">
          <td>{{ item.workCenterId }} </td>
          <td>{{ item.workCenterName }} </td>
          <td>{{ item.active ? 'working':'not working'}} </td>
        </tr>
      </tbody>
    </table>
  </div>
  <div class="row mt-4">
  </div>
</div>
</div>
</template>

<script>
import axios from 'axios'
// import router from '@/router'

export default {
  name: 'staff-home',
  data () {
    return {
      siparisItems: [],
      workCentersItems: []
    }
  },
  props: {
    apiAddrSiparis: String,
    apiAddrWorkCenters: String
  },
  mounted () {
    axios.get(this.apiAddrSiparis).then(response => {
      this.siparisItems = response.data
    })
    axios.get(this.apiAddrWorkCenters).then(response => {
      this.workCentersItems = response.data
      console.log(response.data)
    })
  }
}
</script>

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
