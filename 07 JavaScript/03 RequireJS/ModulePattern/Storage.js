define("storage", [], function () {
    var lastActivity = 1;

    function getAllContacts() {
        lastActivity = new Date();
    }

    function deleteContactById() {
        lastActivity = new Date();
    }

    function dump() {
        console.log("Storage");
    }

    return {
        getAllContacts: getAllContacts,
        deleteContactById: deleteContactById,
    };
});
