function Input(){
    document.getElementById('firstname').removeAttribute('readonly');
    document.getElementById('lastname').removeAttribute('readonly');
    document.getElementById('email').removeAttribute('readonly');
    document.getElementById('telephone').removeAttribute('readonly');
    document.getElementById('saveButton').removeAttribute('hidden')

}

   /* $(".nhatclass")
        .change(function () {
            $( "input ").each(function() {
                 $( this ).type();
            });
            $( "changeButton" ).type("submit");
        })
        .change();*/
$('changeButton').on('click', function () {
    $(this).parents("form:first").submit();
});

