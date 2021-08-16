<template>
    <div class="sPP">
        <StaffPostWorkCenters v-bind:apiAddr="'https://localhost:44305/api/workCenters/add'"/>
    </div>
</template>

<script>
import StaffPostWorkCenters from '@/components/StaffPostWorkCenters.vue'

export default ({
  name: 'staff-post-workcenters',
  components: {
    StaffPostWorkCenters
  }
})
</script>
