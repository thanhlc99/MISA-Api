$(document).ready(function () {
    new Customer();
    //khai báo các thông tin chung cho dialog
    dialogDefault = $('#m-dialog').dialog({
        autoOpen: false,
        fluid: true,
        minWidth: 750,
        height: 637,
        resizable: true,
        position: ({
            my: "center", at: "center", of: window
        }),
        modal: true
    });
})

/**
 * Class quản lý các sự kiện cho trang customer
 * created by mvthanh(26/12/2020)
 * */
class Customer extends BaseJs {
    constructor() {
        super();
    }

    initEvents() {
        var me = this;
        super.initEvents();
        $('#txtSearch').blur(function () {
            var value = $('#txtSearch').val();
            me.filter = "/api/v1/customers/filter?specs=" + value;
            me.loadData();
        })
    }

    setFilter() {
        this.filter = "";
    }

    setDomainNV() {
        this.domainNV = "/api/v1/customers";
    }

}