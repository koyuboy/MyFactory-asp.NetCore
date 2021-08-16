<template>
    <div class="corder">
        <CustomerOrder v-bind:apiAddr="'https://localhost:44305/api/Orders/orderstatus'"/>
    </div>
</template>

<script>
import CustomerOrder from '@/components/CustomerOrders.vue'

export default ({
  name: 'customer-orders',
  components: {
    CustomerOrder
  }
})
</script>
