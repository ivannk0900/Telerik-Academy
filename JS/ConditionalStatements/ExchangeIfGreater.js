// Write an if statement that takes two double variables a and b and exchanges
// values if the first one is greater than the second.
// As a result print the values a and b, separated by a space.

var a = 3.43, b= 2.34;


if(a>b) {
    var temp;
    temp=a;
    a=b;
    b=temp;
}

console.log(a + ' ' + b);
