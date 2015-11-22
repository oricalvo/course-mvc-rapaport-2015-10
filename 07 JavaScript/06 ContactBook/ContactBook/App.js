(function () {
    var root = new Group("~");

    var friends = new Group("Friends");
    root.addItem(friends);

    var ori = new Contact("Ori", "ori@gmail.com");
    root.addItem(ori);

    var roni = new Contact("Roni", "roni@gmail.com");
    friends.addItem(roni);

    root.dump();
})();
