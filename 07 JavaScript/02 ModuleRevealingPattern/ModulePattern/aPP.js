(function (httpGet, Storage) {
    httpGet();

    Storage.getAllContacts();
})(MyApp.Network.httpGet, MyApp.Storage);
