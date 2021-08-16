<template>
    <div class="clogin">
        <login v-bind:apiAddr="'https://localhost:44305/api/Customers/login'" v-bind:is-staff="false"/>
    </div>
</template>

<script>
import login from '@/components/Login.vue'

export default ({
  name: 'customer-login',
  components: {
    login
  }
})
</script>
