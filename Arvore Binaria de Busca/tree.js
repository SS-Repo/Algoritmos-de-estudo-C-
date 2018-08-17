//Tipos para percorrer uma estrutura de arvore binaria

var arvore = {
	//Esquerda
	left: {
		left:{
			value: 1
		},
		right: {
			value: 3
		},
		value: 2
	},
	//Direita
	right: {
		value: 15,
	},
	value: 10
}

//função primeiro de todos elementos
//Pre Ordem
function preOrder(tree){
	console.log(tree.value);

	//verifica se True existem algo dentro da funcao entao
	//ele navega o lado esquerdo
	//se False nao navega
	tree.left && preOrder(tree.left);
	tree.right && preOrder(tree.right);
}
console.log("preOrder");
preOrder(arvore);

//Em Ordem
function inOrder(tree){
	
	tree.left && inOrder(tree.left);
	console.log(tree.value);
	tree.right && inOrder(tree.right);
}

console.log("inOrder");
inOrder(arvore);

//Pos Ordem
function posOrder(tree){
	tree.left && posOrder(tree.left);
	tree.right && posOrder(tree.right);
	console.log(tree.value);
}

console.log("posOrder");
posOrder(arvore);