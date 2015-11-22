var Point = (function () {
    "use strict";

    function Point(x, y) {
        this.x = x;
        this.y = y;
    }

    Point.prototype.dump = function () {
        console.log(this.x + ", " + this.y);
    }

    Point.prototype.move = function (dx, dy) {
        this.x += dx;
        this.y += dy;
    }

    Point.prototype.reset = function () {
        this.x = 0;
        this.y = 0;
    }

    return Point;
})();