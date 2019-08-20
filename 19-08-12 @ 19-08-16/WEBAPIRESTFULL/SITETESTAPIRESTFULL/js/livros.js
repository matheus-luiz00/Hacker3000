
    /* Ao carregar o documento o mesmo inicia o conteudo desde script*/
    jQuery(document).ready(function(){
		CarregarGeneros();
		CarregarEditoras();
		jQuery('#bntSalvar').click(function(){
			 Editing();
			 
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Registro').val("");
			$('#Titulo').val("");
			$('#Isbn').val("");
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
			$('#Isbn').val("");
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
			"url": "http://localhost:59271/Api/Livros/"+id,
			"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				}
			}
	
			$.ajax(settings).done(function (response) {
				$('#Id').val(response.Id);
		        $('#Registro').val(response.Registro);
		        $('#Titulo').val(response.Titulo);
		        $('#ISBN').val(response.Isbn);
		        $('#Genero').val(response.Genero);
                $('#Ativo select').val(response.Ativo);
                $('#Sinopse').val(response.Sinopse);
                $('#Observacoes').val(response.Observacoes);
			});
		
	}
	
	function Editing(){
		var dados = $('#formusuarios').serialize();
		var id = $('#Id').val();

		 var settings = {
		  "crossDomain": true,
		  "url": "http://localhost:59271/Api/Livros/"+id,
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
			  "url": "http://localhost:59271/Api/Livros/"+id,
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
				"url": "http://localhost:59271/Api/Livros",
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
							+ 		'<th>Registro</th>'
							+ 		'<th>Título</th>'
							+ 		'<th>ISBN</th>'
							+ 		'<th>Gênero</th>'
                            + 		'<th>Editora</th>'
                            + 		'<th>Sinopse</th>'
                            + 		'<th>Observaçõess</th>'
							+ 	'</tr>'
							+ '</tbody>');

		$.each(contentValue,function(index,value) {
        var row =     '<tr>'
						+ '<td>' + value.Id       + '</td>'
						+ '<td>' + value.Registro    + '</td>'
						+ '<td>' + value.Titulo    + '</td>'
						+ '<td>' + value.Isbn    + '</td>'
                        + '<td>' + value.Genero    + '</td>'
                        + '<td>' + value.Editora    + '</td>'
                        + '<td>' + value.Sinopse    + '</td>'
                        + '<td>' + value.Observacoes    + '</td>'
						+ '<td>' 
						+ 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
						+ 		'<div    class=\'col-md-6\'>'
						+ 			'<button class=\'btn btn-block btn-danger col-md-3 btn-delet-event\' send-post=\'Livros\'  type=\'button\'  value=\''+ value.Id +'\'>Remover</button>'
						+ 		'</div>'
						+ 		'<div     class=\'col-md-6\'>'
						+ 			'<button  class=\'btn btn-block btn-success btn-editar col-md-3\' send-post=\'Livros\'   type=\'button\'  value=\''+ value.Id +'\'>Editar</button>'
						+ 		'</div>'
						+ 	'</div>'
						+ '</td>'
					+ '</tr>';
        $('#tDataGrid').append(row);
		});
		SetGridClickEvents();
		$('.btn-editar').click(function (){

			var id = $(this).attr('value');
			var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Livros/"+id,
				"method": "GET",
					"headers": {
						"Content-Type": "application/json",
						"Accept": "*/*"
					}
				}
		
				$.ajax(settings).done(function (response) {
					$('#Titulo').val(response.Titulo);
					$('#Id').val(response.Id);
					$('#Isbn').val(response.Isbn);
					$('#Genero').val(response.Genero);
					$('#Ativo select').val(response.Ativo);
					$('#Editora').val(response.Editora);
					$('#Registro').val(response.Registro);
					$('#Sinopse').val(response.Sinopse);
					$('#Observacoes').val(response.Observacoes);
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
                        $('#Genero').append(genero);
                        });
				});
	}
	
	function CarregarEditoras() {
        var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Editoras",
				"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				  }
                }
                
				$.ajax(settings).done(function (response) {
                    $.each(response,function(index,value) {
                        var editora = '<option value="' + value.Id + '">'+ value.Nome +'</option> ';
                        $('#Editora').append(editora);
                        });
				});
    }
  
  