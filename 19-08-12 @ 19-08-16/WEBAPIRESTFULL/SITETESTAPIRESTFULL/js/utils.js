jQuery(document).ready(function(){
    /* Indica que o evento submit do form irá realizar esta ação agora*/
    jQuery('#formusuarios').submit(function(){
        /* Neste contesto 'this' representa o form deste ID  #myform */        

        var dados = $(this).serialize();
        var sendpost = $(this).attr('send-post');
        var callStr = 

         var settings = {
          "crossDomain": true,
          "url": "http://localhost:59271/Api/Locacaos",
          "method": "POST",
          "headers": {
            "Content-Type": "application/x-www-form-urlencoded",
            "Accept": "*/*"
          },
          "data": dados
        }

        $.ajax(settings).done(function (response) {
            GetMethod();
        });
        
        return false;
    });

}