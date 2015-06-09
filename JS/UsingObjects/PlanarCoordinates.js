// Write functions for working with shapes in standard Planar coordinate system.
// Points are represented by coordinates P(X, Y)
// Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
// Calculate the distance between two points.
// Check if three segment lines can form a triangle.

function Point(x, y) {
    this.x = x;
    this.y = y;
}

function Line(point1, point2) {

    this.point1 = point1;
    this.point2 = point2;
    this.getLength = function() {
        var x = (this.point1.x - this.point2.x) * (this.point1.x - this.point2.x);
        var y = (this.point1.y - this.point2.y) * (this.point1.y - this.point2.y);
        return Math.sqrt(x + y);
    };

}

Point.prototype.toString = function() {
    return 'Point(' + this.x + ',' + this.y + ')';
};

Line.prototype.toString = function() {
    var x = (this.point1.x - this.point2.x) * (this.point1.x - this.point2.x);
    var y = (this.point1.y - this.point2.y) * (this.point1.y - this.point2.y);

   return 'start: '+ this.point1.toString() + ' end: ' + this.point2.toString() + ' length: ' + Math.sqrt(x + y);
};

function checkTriangle(a,b,c) {

    return a.getLength()< b.getLength()+ c.getLength() &&
           b.getLength() < a.getLength() + c.getLength() &&
           c.getLength() < a.getLength() + b.getLength();
}


var A = new Point(2,20);
var B = new Point(1,1);
var C = new Point(1,2);
var c = new Line(A,B);
var a = new Line(B,C);
var b = new Line(A,C);

console.log(a.getLength());
console.log(b.getLength());
console.log(c.getLength());

console.log(checkTriangle(a,b,c));