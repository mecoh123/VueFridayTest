<template>
    <div id="app" class="container-fluid">
        <div class="row">
            <div class="col-sm-3">
                <nav-menu params="route: route"></nav-menu>
            </div>
            <div class="col-sm-9">
                <router-view></router-view>
            </div>
        </div>
</div>

</template>

<script>
import Vue from 'vue'
import CounterExample from './counter-example'
import FetchData from './fetch-data'
import HomePage from './home-page'
import NavMenu from './nav-menu'
import AboutUs from './about-us'
import UserPage from './user-page'

import '@progress/kendo-ui'
import '@progress/kendo-theme-default/dist/all.css'

import { Grid, GridInstaller } from '@progress/kendo-grid-vue-wrapper'
import { DataSource, DataSourceInstaller } from '@progress/kendo-datasource-vue-wrapper'

Vue.use(GridInstaller)
Vue.use(DataSourceInstaller)


Vue.component('counter-example', CounterExample);
Vue.component('fetch-data', FetchData);
Vue.component('home-page', HomePage);
Vue.component('nav-menu', NavMenu);
Vue.component('about-us',  AboutUs);
Vue.component('user-page', UserPage);

export default {
    data() {
        return {             
        }
    },
    components: {
        Grid,
        DataSource
    }    
}
</script>

<style>
</style>