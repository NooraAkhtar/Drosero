
function addToCartViewModel(magazineModel) {
  var model = magazineModel;
  model.cartItem = ko.observableArray();
  model.totalItem = ko.computed(function() {
    if (model.cartItem) {
      return model.cartItem().length;
    }
    return 0;
  });

  model.totalValue = ko.computed(function() {
    var result = 0.0;
    if (model.cartItem()) {
      if (model.cartItem() && model.cartItem().length > 0)
        for (var index = 0; index < model.cartItem().length; index++) {
          result += model.cartItem()[index].Price;
        }
    }
    return result;
  });

  model.addItems = function(foodItem) {
    model.cartItem.push(foodItem);
    return model.cartItem();
  };

  model.removeItem = function(foodItem) {
    model.cartItem.pop(foodItem);
    return model.cartItem();
  };
};

////var foodItem = foodItem || {};
////foodItem = {
////  price: ko.observable(0.0),
////  foodItemId: ko.observable(0),
////  categoryId: ko.observable(0),
////  name:ko.observable('')
////}
