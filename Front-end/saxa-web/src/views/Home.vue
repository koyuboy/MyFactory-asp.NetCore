<template>
<nav class="navbar navbar-dark bg-dark">
    <div class="container-fluid">
    <router-link to="/" class="nav-link">Home</router-link>
    <router-link to="/clogin" name="nav-login" class="nav-link">Customer Login </router-link>
    <router-link to="/slogin" name="nav-login" class="nav-link">Staff Login</router-link>
  </div>
</nav>
    <HelloWorld msg="Welcome to Your Vue.js App"/>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'home',
  components: {
    HelloWorld
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
