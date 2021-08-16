import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/clogin',
    name: 'CustomerLogin',
    component: () => import(/* webpackChunkName: "about" */ '../views/CustomerLogin.vue')
  },
  {
    path: '/slogin',
    name: 'StaffLogin',
    component: () => import(/* webpackChunkName: "about" */ '../views/StaffLogin.vue')
  },
  {
    path: '/chome',
    name: 'CustomerHome',
    component: () => import(/* webpackChunkName: "about" */ '../views/CustomerHome.vue')
  },
  {
    path: '/shome',
    name: 'StaffHome',
    component: () => import(/* webpackChunkName: "about" */ '../views/StaffHome.vue')
  },
  {
    path: '/postProduct',
    name: 'PostProduct',
    component: () => import(/* webpackChunkName: "about" */ '../views/StaffPostProduct.vue')
  },
  {
    path: '/postProductTree',
    name: 'PostProductTree',
    component: () => import(/* webpackChunkName: "about" */ '../views/StaffPostProductTree.vue')
  },
  {
    path: '/postMachines',
    name: 'PostWorkCenters',
    component: () => import(/* webpackChunkName: "about" */ '../views/StaffPostWorkCenters.vue')
  },
  {
    path: '/postOperations',
    name: 'PostOperations',
    component: () => import(/* webpackChunkName: "about" */ '../views/StaffPostOperations.vue')
  },
  {
    path: '/orderhistory',
    name: 'OrderHistory',
    component: () => import(/* webpackChunkName: "about" */ '../views/CustomerOrderHistory.vue')
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
