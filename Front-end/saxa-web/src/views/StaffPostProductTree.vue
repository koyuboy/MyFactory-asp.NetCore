<template>
    <div class="sPP">
        <StaffPostProductTree v-bind:apiAddr="'https://localhost:44305/api/subProductTrees/add'"/>
    </div>
</template>

<script>
import StaffPostProductTree from '@/components/StaffPostProductTree.vue'

export default ({
  name: 'staff-post-product-tree',
  components: {
    StaffPostProductTree
  }
})
</script>
