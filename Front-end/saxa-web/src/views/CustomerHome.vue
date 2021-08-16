<template>
    <div class="corder">
        <CustomerHome v-bind:apiAddr="'https://localhost:44305/api/Products/getsalableproducts'"/>
    </div>
</template>

<script>
import CustomerHome from '@/components/CustomerHome.vue'

export default ({
  name: 'customer-home',
  components: {
    CustomerHome
  }
})
</script>
