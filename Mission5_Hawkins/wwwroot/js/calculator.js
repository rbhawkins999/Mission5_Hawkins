//java script to make the calculator work
$(document).ready(function () {
    $('#calculateTotal').click(function () {
        var hours = parseFloat($('#hours').val());
        var hourlyRate = parseFloat($('#hourlyRate').val());

        //makes sure the input is valid
        if (isNaN(hours) || hours <= 0) {
            alert('Please enter a valid number of hours.');
            return;
        }

        //calculates the total
        var total = hours * hourlyRate;

        //displays the total
        $('#total').val('$' + total.toFixed(2));
    });
});