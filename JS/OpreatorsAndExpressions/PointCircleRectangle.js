// Write an expression that checks for given point P(x, y)
// if it is within the circle K( (1,1), 3) and out of the
// rectangle R(top=1, left=-1, width=6, height=2).

var x = 2.5, y= 1.5, r = 3;

var OT = Math.sqrt((x - 1) * (x - 1) + (1 - y) * (1 - y)); //OT-distance between the centre of the circle and the given point
if (OT > r) {
    console.log("no");
    } else {
    if (y > 2) {
        console.log("no");
    }
    else console.log("yes");
}