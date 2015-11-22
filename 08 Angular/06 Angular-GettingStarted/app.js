var app = angular.module("MyApp", []);

function HomeCtrl($scope){
	$scope.contacts = [
		{id: 1, name: "Ori"},
		{id: 2, name: "Roni"},
	];			
	
	$scope.remove = function(contact, index) {
		//alert(contact.id);
		$scope.contacts.splice(index, 1);
	}
}

app.controller("HomeCtrl", HomeCtrl);

