var triviaUI = triviaUI || {};
triviaUI = {
  triviaViewModel: {},
  bindingApplied:false,

  init: function (viewModel) {
    if (!triviaUI.bindingApplied) {
      triviaUI.viewModel = ko.mapping.fromJSON(viewModel);
      ko.applyBindings(triviaUI.triviaViewModel);
    }
  }
};