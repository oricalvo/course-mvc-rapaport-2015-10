class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }
    dump() {
    }
}
Point.nextId = 1000;
class PointEx extends Point {
    constructor() {
        super(5, 10);
    }
}
var pt = new Point(5, 10);
pt.dump();
