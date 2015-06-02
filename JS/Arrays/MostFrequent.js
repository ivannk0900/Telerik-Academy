var arr = [1,1,1,1,2,2,2,2,2],
    maxCount = 0,
    count = 0,
    i = 0,
    j = 0,
    digit = arr[0];


for( i; i<arr.length; i+=1)
{
    count = 0; j = 0;
    for( j; j<arr.length; j+=1) {
        if(arr[j]===arr[i]) {
            count+=1;
        }
    }
    if(count>maxCount) {
        maxCount=count;
        digit=arr[i];
    }
}


console.log(digit + ' -> ' + maxCount + ' times');
