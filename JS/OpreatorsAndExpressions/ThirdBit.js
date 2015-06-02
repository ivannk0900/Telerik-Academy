// Write a boolean expression for finding if the bit 3
// (counting from 0) of a given integer is 1 or 0.

var number = 8;

if((number >> position) & 1==1) {
    console.log('is one');
} else {
    console.log('is zero');
}