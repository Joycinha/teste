Funcionalidade: Pesquisa de passagem
	
@PesquisarPassagemMenorTarifa
Cenario: Pesquisar passagem com menor tarifa para dois adultos
	Dado que eu acesse o site da Gol
	Quando eu informo a origem e destino
	E seleciono a data de ida e de volta
	E seleciono a quantidade de passageiros	
	Então o sistema me retornará o resultado da pesquisa
	E eu selecionarei a menor tarifa do dia
