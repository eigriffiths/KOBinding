﻿var ObjectState = {
    Unchanged: 0,
    Added: 1,
    Modified: 2,
    Deleted: 3
}


SalesORderViewModel = function (data) {
    var self = this;
    ko.mapping.fromJS(data, {}, self);

    self.save = function() {
            $.ajax({
                url: "/Sales/Save/",
                type: "POST",
                data: ko.toJSON(self),
                contentType: "application/json",
                success: function(data) {
                    if (data.salesOrderViewModel != null)
                        ko.mapping.fromJS(data.salesOrderViewModel, {}, self);

                    if (data.newLocation != null)
                        window.locaiton = data.newLocation;
                }
            });
        },
        self.flagSalesOrderAsEdited = function () {
        if (self.ObjectState() != ObjectState.Added) {
            self.ObjectState(ObjectState.Modified);
        }
         return true;
        };

}