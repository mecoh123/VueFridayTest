<template>
    <div id="user-page">
        <h1>User</h1>
        <kendo-grid id="grid" 
                    :data-source="this.source()"
                    :pageable='true'
                    :scrollable="false"
                    :editable="'popup'"
                    :selectable="true"
                    :toolbar="['create']">
            <kendo-grid-column title="First Name" field="firstName"></kendo-grid-column>
            <kendo-grid-column title="Middle Name" field="middleName"></kendo-grid-column>
            <kendo-grid-column title="Last Name" field="lastName"></kendo-grid-column>
            <kendo-grid-column 
                title="Number To Word" 
                field="numberToWord"
                :template="this.NumberToWord('numberToWord')"
                ></kendo-grid-column>
            <kendo-grid-column title="Birthday" field="birthday"                
            ></kendo-grid-column>
            <kendo-grid-column title="Gender" field="gender"></kendo-grid-column>
            <kendo-grid-column title="Status" field="status"></kendo-grid-column>
            <kendo-grid-column title="Location" field="location"></kendo-grid-column>
            <kendo-grid-column :command="['edit', 'destroy']" title="Action" width="170px"></kendo-grid-column>
        </kendo-grid>
    </div>
</template>

<script>
    // template="#= myModule.prettyDate(birthday) #"
    
    import $ from 'jquery'
    import mxn from 'mixins/globalmixins.js'
    import globalModule from 'globalmodule/globalmodule.js'

    // console.log(globalModule.prettyDate("1991/12/12"));

    export default {
        name: "User",
        mixins: [mxn],
        data: function() {
            return {
            }
        },
        methods: {
            source: function() {
                return new kendo.data.DataSource({
                    transport: {
                        read: {
                            url: "api/User/Read",
                            dataType: "json",
                            type: "get"
                        }
                    },
                    type: "aspnetmvc-ajax",
                    serverPaging: true,
                    serverFiltering: true,
                    serverSorting: true,
                    pageSize: 5,
                    schema: {
                        data: "data",
                        total: "total",
                        errors: "errors",
                        model: {
                            id: "id",
                            fields: {
                                id: { type: "number", editable: false, nullable: false },
                                firstName: { type: 'string' },
                                middleName: { type: 'string' },
                                lastName: { type: 'string' },
                                numberToWord: { type: 'string' },
                                birthday: { type: 'date' },
                                gender: { type: 'string' },
                                location: { type: 'string' }
                            }
                        }
                    }
                });
            }
        }
    }
</script>

<style>

</style>
