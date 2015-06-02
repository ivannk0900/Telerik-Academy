// Write a script that prints all the numbers from 1 to N,
// that are not divisible by 3 and 7 at the same time

var n=100,
    i=1;

for(i; i <= n; i += 1) {
    if((i%5)&&(i%7)) {
        console.log(i);
    }
}