var reservationUI = reservationUI || {};

reservationUI = {

  onReservation: function (customer) {
    $.ajax({
      url: '/DroseroMVC/Home/SendSms',
      method: "POST",
      data: { 'customer': customer },
      success: function (data) {
        debugger;
        if (data.Status == "Delivered") {
          alert('Reservation' );
        }
      },
      error: function (data) {
        debugger;
        alert('Reservation' + data);
      }
    });
  }

}