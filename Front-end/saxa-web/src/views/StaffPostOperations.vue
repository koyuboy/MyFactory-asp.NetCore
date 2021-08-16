<template>
    <div class="sPP">
        <StaffPostOperations v-bind:apiAddr="'https://localhost:44305/api/Operations/add'"/>
    </div>
</template>

<script>
import StaffPostOperations from '@/components/StaffPostOperations.vue'

export default ({
  name: 'staff-post-operations',
  components: {
    StaffPostOperations
  }
})
</script>
