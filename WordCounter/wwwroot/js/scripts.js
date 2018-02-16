$(document).ready(function() {
  $(".content").fadeIn();
  
  $("#option").change(function(){
    if($(this).val() === "one")
    {
      $("#search").fadeIn();
    }
    else{
      $("#search").fadeOut();
    }
  });
});