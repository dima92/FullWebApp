"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Order = /** @class */ (function () {
    function Order(id, rent, description, startDate, endDate, CarId, UserId) {
        this.id = id;
        this.rent = rent;
        this.description = description;
        this.startDate = startDate;
        this.endDate = endDate;
        this.CarId = CarId;
        this.UserId = UserId;
    }
    return Order;
}());
exports.Order = Order;
//# sourceMappingURL=order.js.map