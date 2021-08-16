<template>
<nav class="navbar navbar-dark bg-dark">
    <div class="container-fluid">
    <router-link to="/" class="nav-link">Home</router-link>
  </div>
</nav>

<div class="row g-3 mt-5">
  <div class="col">
  <div class="login container">
    <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Username</label>
        <input v-model="name" type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp"/>
        <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
        <div class="mb-3">
          <label for="exampleInputPassword1" class="form-label">Password</label>
        <input v-model="password" type="password" class="form-control" id="exampleInputPassword1"/>
        </div>
      </div>
    </div>
    <button class="btn btn-primary" @click="login">Login</button>
  </div>
</div>
</template>

<script>
import axios from 'axios'
import router from '@/router'

export default {
  name: 'login',
  data () {
    return {
      name: '',
      password: '',
      response: true
    }
  },
  props: {
    apiAddr: String,
    isStaff: Boolean
  },
  methods: {
    login () {
      axios.post(this.apiAddr, null, {
        params: {
          name: this.name,
          password: this.password
        }
      })
        .then(response => {
          if (response.data) {
            this.response = response.data
            if (!this.isStaff) {
              console.log('Customer Login Successful')
              router.push('/chome')
            } else {
              console.log('Staff Login Successful')
              router.push('/shome')
            }
          }
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
