<template>
    <div class="sPP">
        <StaffPostProduct v-bind:apiAddr="'https://localhost:44305/api/Products/add'"/>
    </div>
</template>

<script>
import StaffPostProduct from '@/components/StaffPostProduct.vue'

export default ({
  name: 'staff-post-product',
  components: {
    StaffPostProduct
  }
})
</script>
