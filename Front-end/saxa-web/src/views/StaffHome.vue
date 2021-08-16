<template>
    <div class="shome">
        <StaffHome v-bind:apiAddrSiparis="'https://localhost:44305/api/Orders/getall'" v-bind:apiAddrWorkCenters="'https://localhost:44305/api/WorkCenters/getall'"/>
    </div>
</template>

<script>
import StaffHome from '@/components/StaffHome.vue'

export default ({
  name: 'staff-home',
  components: {
    StaffHome
  }
})
</script>
