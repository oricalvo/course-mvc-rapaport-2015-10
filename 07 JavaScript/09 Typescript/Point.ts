class Point {
	private x: number;
    private y: number;

	constructor(x: number, y: number) {
		this.x = x;
		this.y = y;
    }

    static nextId: number = 1000;

	dump() {
	}
}

class PointEx extends Point {
    constructor() {
        super(5, 10);
    }
}

var pt = new Point(5, 10);
pt.dump();
