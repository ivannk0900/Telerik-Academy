//  Appearance count
//  Write a function that counts how many times given number appears in given array.
//  Write a test function to check if the function is working correctly.

function count(arr, number) {
    var i= 0,
        counter =0;
    for(i;i<arr.length;i+=1)
    {
        if(arr[i]===number)
        {
            counter+=1;
        }
    }
    return counter;
}

function test(arg1 , arg2) {
    var i= 0,
        res =0;
    for(i;i<arg1.length;i+=1)
    {
        if(arg1[i]===arg2)
        {
            res+=1;
        }
    }
    if(count(arg1,arg2)===res)
    {
        return true;
    }

        return false;

}

var arr = [1,1,2,3,4,5,6,7,8,9],
    number = 1;
console.log('Number of times: '+ count(arr,number));
console.log('Does it works: '+ test(arr,number));