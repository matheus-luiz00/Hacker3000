
    /* Ao carregar o documento o mesmo inicia o conteudo desde script*/
    jQuery(document).ready(function(){
        CarregarLivros();
        CarregarGeneros();
        CarregarUsuarios();
		/* Indica que o evento submit do form irá realizar esta ação agora*/
		jQuery('#formusuarios').submit(function(){
			/* Neste contesto 'this' representa o form deste ID  #myform */                
			var dados = $(this).serialize();

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
		
		jQuery('#bntSalvar').click(function(){
			 Editing();
			 
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Registro').val("");
			$('#Titulo').val("");
			$('#ISBN').val("");
			$('#Genero').val("");
            $('#Ativo select').val("true");
            $('#Sinopse').val("");
            $('#Observacoes').val("");
		});
		
		jQuery('#bntCancelar').click(function(){
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Registro').val("");
			$('#Titulo').val("");
			$('#ISBN').val("");
			$('#Genero').val("");
            $('#Ativo select').val("true");
            $('#Sinopse').val("");
            $('#Observacoes').val("");
		});
		
		GetMethod();
	});
	
	function GetByID(id){
        $('#bntSubmit').hide();
		$('#bntSalvar').show();
		$('#bntCancelar').show();
		
        var settings = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Locacaos/"+id,
			"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				}
			}
	
			$.ajax(settings).done(function (response) {
                $('#Livro').val(response.Id);
				$('#Id').val(response.Id);
                $('#Tipo').val(response.Tipo);
                $('#Usuario').val(response.Usuario);
                $('#Ativo select').val(response.Ativo);
                $('#Devolucao').val(response.Devolucao);
			});
		
	}
	
	function Editing(){
		var dados = $('#formusuarios').serialize();
		var id = $('#Id').val();

		 var settings = {
		  "crossDomain": true,
		  "url": "http://localhost:59271/Api/Locacaos/"+id,
		  "method": "PUT",
		  "headers": {
			"Content-Type": "application/x-www-form-urlencoded",
			"Accept": "*/*"
		  },
		  "data": dados
		}

		$.ajax(settings).done(function (response) {
		    GetMethod();
		});
	}
	
	function Deleting(id){
			 var settings = {
			  "crossDomain": true,
			  "url": "http://localhost:59271/Api/Locacaos/"+id,
			  "method": "DELETE",
			  "headers": {
				"Content-Type": "application/x-www-form-urlencoded",
				"Accept": "*/*"
			  }
			}

			$.ajax(settings).done(function (response) {
			    GetMethod();
			});
	}
    
    function GetMethod(){
			var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Locacaos",
				"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				  }
				}

				$.ajax(settings).done(function (response) {
				  RefreshGrid(response);
				});
			
			return false;
    }
   
    function RefreshGrid(contentValue){
        
	   $('#tDataGrid').empty();
	   $('#tDataGrid').html(  '<tbody>'
							+ 	'<tr>'
							+ 		'<th>ID</th>'
							+ 		'<th>Livro</th>'
							+ 		'<th>Usuario</th>'
							+ 		'<th>Gênero</th>'
							+ 		'<th>Devolução</th>'
							+ 	'</tr>'
							+ '</tbody>');

                            
		$.each(contentValue,function(index,value) {
        var row =     '<tr>'
						+ '<td>' + value.Id       + '</td>'
						+ '<td>' + value.Livros.Titulo    + '</td>'
						+ '<td>' + value.Usuarios.Nome    + '</td>'
						+ '<td>' + value.Livros.Generos.Tipo    + '</td>'
                        + '<td>' + value.Devolucao    + '</td>'
						+ '<td>' 
						+ 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
						+ 		'<div    class=\'col-md-6\'>'
						+ 			'<button class=\'btn btn-block btn-danger col-md-3 ajax\' type=\'button\'  onclick=\'Deleting('+ value.Id +')\'>Remover</button>'
						+ 		'</div>'
						+ 		'<div     class=\'col-md-6\'>'
						+ 			'<button  class=\'btn btn-block btn-success col-md-3\'    type=\'button\'  onclick=\'GetByID('+ value.Id +')\'\>Editar</button>'
						+ 		'</div>'
						+ 	'</div>'
						+ '</td>'
					+ '</tr>';
        $('#tDataGrid').append(row);
        });
    }

    function CarregarLivros() {
        var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Livros",
				"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				  }
                }
                
				$.ajax(settings).done(function (response) {
                    $.each(response,function(index,value) {
                        var livro = '<option value="' + value.Id + '">'+ value.Titulo +'</option> ';
                        $('#Livro').append(livro);
                        });
				});
			
			


        
    }

    function CarregarGeneros() {
        var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Generos",
				"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				  }
                }
                
				$.ajax(settings).done(function (response) {
                    $.each(response,function(index,value) {
                        var genero = '<option value="' + value.Id + '">'+ value.Tipo +'</option> ';
                        $('#Tipo').append(genero);
                        });
				});
    }
    function CarregarUsuarios() {
        var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Usuarios",
				"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				  }
                }
                
				$.ajax(settings).done(function (response) {
                    $.each(response,function(index,value) {
                        var usuario = '<option value="' + value.Id + '">'+ value.Nome +'</option> ';
                        $('#Usuario').append(usuario);
                        });
				});
    }

	
	
  
  