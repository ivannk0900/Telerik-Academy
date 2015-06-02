// Write a script that finds the max and min number from a sequence of numbers.

var sequence = [12,13,4,1,2,3,5,-7,3,33,55,6,23],
    i= 0,
    max = -1000,
    min = 1000;

for(i; i<sequence.length; i+=1) {
    if(sequence[i]>max) {
        max=sequence[i];
    }
    if(sequence[i]<min) {
        min = sequence[i];
    }
}

console.log(min);
console.log(max);