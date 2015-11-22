define(["common.network", "storage"], function (Network, Storage) {
    Network.httpGet();

    Storage.getAllContacts();
});
