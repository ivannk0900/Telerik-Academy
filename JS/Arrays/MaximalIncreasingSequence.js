// Write a script that finds the maximal increasing sequence in an array.

var arr = [2, 2, 3, 4, 2, 2, 4,5],
    i = 0,
    j = 0,
    count = 0,
    maxCount = 0,
    digit;

for(i; i < arr.length-1;i+=1) {
    if(arr[i]===arr[i+1]-1) {
        count+=1;
        if(count>maxCount) {
            maxCount = count;
            digit=arr[i];
        }
    } else {
        count =0;
    }
}

for(j; j < maxCount+1;j+=1) {
     console.log(digit-maxCount+j+1);
}