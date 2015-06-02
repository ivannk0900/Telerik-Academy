// Write a script that finds the maximal sequence of equal elements in an array.

var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2,1, 2],
    i = 0,
    j= 0,
    count = 0,
    maxCount = 0,
    digit = 0;

for(i; i < arr.length-1; i +=1) {
    if(arr[i]===arr[i+1]) {
        count+=1;
        if(count>maxCount) {
            maxCount=count;
            digit=arr[i];
        }

    } else {
        count = 0;
    }
}

for(j ; j < maxCount+1;j+=1) {
    console.log(digit);
}