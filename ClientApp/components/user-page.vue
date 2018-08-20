<template>
    <div id="user-page">
        <h1>User</h1>
        <kendo-grid :data-source="dataSource"
                    :pageable='true'
                    :scrollable="false"
                    :editable="'popup'"
                    :toolbar="['create']">
            <kendo-grid-column field="firstName"></kendo-grid-column>
            <kendo-grid-column field="middleName"></kendo-grid-column>
            <kendo-grid-column field="lastName"></kendo-grid-column>
            <kendo-grid-column field="birthday"></kendo-grid-column>
            <kendo-grid-column field="gender"></kendo-grid-column>
            <kendo-grid-column field="status"></kendo-grid-column>
            <kendo-grid-column field="location"></kendo-grid-column>
            <kendo-grid-column :command="['edit', 'destroy']" title="&nbsp;" width="170px"></kendo-grid-column>
        </kendo-grid>
    </div>
</template>

<script>
    const url = "http://localhost:56848/api/User/Read"

    export default {
        name: "User",
        methods: {     
        },
        data: function() {
            return {
                dataSource: {
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
                    pageSize: 1,
                    schema: {
                        data: "data",
                        total: function (rspns) {
                            return rspns.total;
                        },
                        errors: function (err) {
                            return err.errors;
                        },
                        model: {
                            id: "id",
                            fields: {
                                id: { type: "number", editable: false, nullable: false },
                                firstName: { type: 'string' },
                                middleName: { type: 'string' },
                                lastName: { type: 'string' },
                                birthday: { type: 'date' },
                                gender: { type: 'string' },
                                location: { type: 'string' }
                            }
                        }
                    }

                }
            }
        },
        async mounted() {

        }
    }
</script>

<style>

</style>
