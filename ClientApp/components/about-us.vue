<template>
    <div>
        <h1>About Us</h1>
        <p>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
        </p>

        <kendo-grid :data-source="localDataSource"
                    v-on:databinding="onDataBinding"
                    v-on:databound="onDataBound">
        </kendo-grid>
        
    </div>
</template>

<script>
export default {
    methods: {
        onDataBinding: function (ev) {
            console.log("Grid is about to be bound!");
        },
        onDataBound: function (ev) {
            console.log("Grid is now bound!");
        }
    },
    data: function() {
        return {
            localDataSource: [{
                    "ProductID": 1,
                    "ProductName": "Chai",
                    "UnitPrice": 18,
                    "UnitsInStock": 39,
                    "Discontinued": false,
                },
                {
                    "ProductID": 2,
                    "ProductName": "Chang",
                    "UnitPrice": 17,
                    "UnitsInStock": 40,
                    "Discontinued": false,
                },
                {
                    "ProductID": 3,
                    "ProductName": "Aniseed Syrup",
                    "UnitPrice": 10,
                    "UnitsInStock": 13,
                    "Discontinued": false,
                }
            ]
        }
    }
}
</script>

<style>
</style>
