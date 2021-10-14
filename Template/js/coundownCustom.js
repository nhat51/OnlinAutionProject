$('.clock').each(function() {
    var $this = $(this), finalDate = $(this).data('countdown');
    $this.countdown(finalDate, function(event) {
        var format = '%H:%M:%S';
        if(event.offset.totalDays > 0) {
            format = '%-d day%!d ' + format;
        }
        if(event.offset.weeks > 0) {
            format = '%-w week%!w ' + format;
        }
        $(this).html(event.strftime(format));

        $(this).on('finish.countdown', function(event) {
            $(this).html('This auction has expired!')
                .parent().addClass('disabled');
        });
    })


});
