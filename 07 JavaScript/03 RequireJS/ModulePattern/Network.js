define("common.network", [], function () {
    var lastActivity = 2;

    function httpGet() {
        lastActivity = new Date();
    }

    function httpPost() {
        lastActivity = new Date();
    }

    function dump() {
        console.log("Network");
    }

    return {
        httpGet: httpGet,
        httpPost: httpPost,
    };
});
