<template>
    <div class="slogin">
        <login v-bind:apiAddr="'https://localhost:44305/api/Users/login'" v-bind:is-staff="true"/>
    </div>
</template>

<script>
import login from '@/components/Login.vue'

export default ({
  name: 'staff-login',
  components: {
    login
  }
})
</script>
