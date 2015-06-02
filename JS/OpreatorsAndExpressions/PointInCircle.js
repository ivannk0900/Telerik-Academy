// Write an expression that checks if given point P(x, y)
// is within a circle K({0,0}, 5). //{0,0} is the centre
// and 5 is the radius

var x=0, y= 1, r=5;
var pointDistance = Math.sqrt(x*x+y*y);

if(pointDistance<r) {
    console.log('true');
} else {
    console.log('false');
}
