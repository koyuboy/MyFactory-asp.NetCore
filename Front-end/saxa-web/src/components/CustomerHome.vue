<template>
<nav class="navbar navbar-dark bg-dark">
    <div class="container-fluid">
    <router-link to="/orderhistory" class="nav-link">Order History</router-link>
    <a class="nav-link" @click="showBasket">Basket/Store</a>
    <router-link to="/" class="navbar-brand">Exit</router-link>
    </div>
</nav>
<div v-show="!isBasketSeen">
<div class="container pt-5">
  <div class="row">
    <div class="col">
      <ul v-for="item in items" :key="item">
        <li>
          <div id="product-name">
          {{ item.productName }}
          </div>
          <div id="product-type">
          {{ item.productType }}
          </div>
          <button type="button" class="btn btn-success m-3" @click="addToBasket(item)">Add</button>
          <button type="button" class="btn btn-secondary m-3" @click="deleteFromBasket(item)">Delete</button>
        </li>
      </ul>
  </div>
</div>
</div>
</div>
<div v-show="isBasketSeen">
  <div class="p-5">
<table class="table table-dark table-hover">
  <thead>
    <tr>
      <th scope="col">Product Name</th>
      <th scope="col">Product Type</th>
    </tr>
  </thead>
  <tbody>
    <tr v-for="item in basket" :key="item">
      <td>{{ item.productName }} </td>
      <td>{{ item.productType }} </td>
    </tr>
  </tbody>
</table>
</div>
<button class="btn btn-success m-3" @click="confirm">Confirm</button>
</div>

</template>

<script>
import axios from 'axios'

export default {
  components: { },
  name: 'customer-home',
  data () {
    return {
      items: [],
      basket: [],
      isBasketSeen: false
    }
  },
  props: {
    apiAddr: String
  },
  mounted () {
    axios.get(this.apiAddr).then(response => {
      this.items = response.data
    })
  },
  methods: {
    addToBasket (item) {
      this.basket.push(item)
      console.log(this.basket)
    },
    deleteFromBasket (item) {
      const isInBasket = this.basket.includes(item)
      console.log(isInBasket)
      if (isInBasket) {
        this.basket.splice(this.basket.indexOf(item), 1)
      } else {
        alert('Item is not in basket')
      }
    },
    showBasket () {
      console.log('Show basket')
      if (!this.isBasketSeen) {
        this.isBasketSeen = true
        this.divid.style.display = 'none'
      } else {
        this.isBasketSeen = false
        this.divid.style.display = 'inital'
      }
    },
    confirm () {
      console.log(JSON.stringify(this.basket))

      axios.post('https://localhost:44305/api/Orders/add')

      for (let index = 0; index < this.basket.length; index++) {
        axios.post('https://localhost:44305/api/OrderItems/add', {
          productId: this.basket[index].productId,
          productName: this.basket[index].productName,
          productType: this.basket[index].productType
        })
          .then(response => {
            console.log(response.data)
          })
      }
      alert('Successful')
    }
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
