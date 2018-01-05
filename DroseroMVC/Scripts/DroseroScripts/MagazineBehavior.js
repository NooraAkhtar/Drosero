var magazineUI = magazineUI || {};
magazineUI = {
  magazineViewModel: {},
  bindingApplied: false,
  selectedCategory: ko.observable('Test'),

  init: function (viewModel) {
    if (!magazineUI.bindingApplied) {
      magazineUI.magazineViewModel = ko.mapping.fromJS(viewModel);
      magazineUI.magazineViewModel.totalCartValue = ko.observable(0.0);
      magazineUI.magazineViewModel.foodItemsByCategory = ko.observable();
      magazineUI.magazineViewModel.subCategories = ko.observable();
      
      addToCartViewModel(magazineUI.magazineViewModel);

      magazineUI.bindingApplied = true;
      ko.applyBindings(magazineUI.magazineViewModel);
    }
    magazineUI.getDefaultCategorySelection();
  },

  onloadCartItems: function() {
    $("#addToCart").style.display = "block";
  },

  getDefaultCategorySelection: function() {
    if (magazineUI.magazineViewModel.CategoryViewModel &&
      magazineUI.magazineViewModel.CategoryViewModel.Categories &&
      magazineUI.magazineViewModel.CategoryViewModel.Categories().length > 0) {
      magazineUI.onCategoryClick(magazineUI.magazineViewModel.CategoryViewModel.Categories()[0].Id());
    }
  },

  onCategoryClick: function (id) {
    magazineUI.magazineViewModel.PageTitle(magazineUI.getCategoryById(id));
    magazineRepository.loadFoodItemByCategory(id);
  },

  onSubCategoryClick: function (id) {
    magazineRepository.loadFoodItemByCategory(id);
  },

  getSubCategories: function (id) {
    magazineRepository.getSubCategories(id);
  },

  onSuccessSubCategories: function (data) {
    debugger;
    $("#subCategories").data(data);
    //magazineUI.magazineViewModel.subCategories = ko.observable(data);
  },

  onSubCategoryLoaded: function (data) {
    //var firstSubCategory = data[0].
  },

  onAddToCart: function (id) {
    var selectedItem = magazineUI.getFoodItemById(id);
    if (selectedItem) {
      var items = magazineUI.magazineViewModel.addItems(selectedItem);
      var cartViewModel = magazineUI.magazineViewModel.CartItemsViewModel;
      cartViewModel.FoodItems(items);
    }
  },

  onSuccessFoodByCategory: function (data) {
    $('#foodByCategory').html(data);
  },

  getCategoryById: function (id) {
    var pageTile = "Categories";
    var categories = magazineUI.magazineViewModel.CategoryViewModel.Categories();
    for (var index = 0; index < categories.length; index++) {
      if (categories[index].Id() == id) {
        pageTile = categories[index].Name();
        break;
      }
    }
    return pageTile;
  },

  getFoodItemById: function(id) {
    for (var index = 0; index < magazineUI.foodItemsByCategory.length; index++) {
      if (id === magazineUI.foodItemsByCategory[index].Id) {
        return magazineUI.foodItemsByCategory[index];
      }
    }
    return null;
  }
};

var magazineRepository = magazineRepository || {};
magazineRepository = {
  loadFoodItemByCategory: function(categoryId) {
    $.ajax({
      url: '/DroseroMVC/Magazine/GetFoodItemsByCategory',
      method: "POST",
      data: { 'categoryId': categoryId },
      success: function(data) {
        magazineUI.onSuccessFoodByCategory(data);
      }
    });
  }, 

  getSubCategories: function (id) {
    $.ajax({
      url: '/DroseroMVC/Magazine/GetSubCategories',
      method: "GET",
      data: { 'id': id },
      success: function (data) {
        magazineUI.onSuccessSubCategories(data);
      }
    });
  }
};
