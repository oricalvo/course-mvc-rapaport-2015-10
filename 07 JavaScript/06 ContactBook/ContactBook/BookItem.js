var BookItem = (function () {

    var nextId = 1;

    function BookItem() {
        this.id = nextId++;
        this.parent = null;
    }

    BookItem.prototype.onAdded = function (parent) {
        this.parent = parent;
    }

    return BookItem;

})();
