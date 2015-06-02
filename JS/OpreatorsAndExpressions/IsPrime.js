// Write an expression that checks if
// given positive integer number n (n ? 100) is prime.

var number = 97;
var isPrime = true;

if(number<0 || number > 100) {
    console.log('false');
}
else {
    for (var i = 2; i <= number - 1; i++ ) {
        if(number%i==0) {
            isPrime=false;
            break;
        }
    }
    console.log(isPrime);
}