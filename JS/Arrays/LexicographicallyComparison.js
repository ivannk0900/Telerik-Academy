// Write a script that compares two char arrays lexicographically (letter by letter).

var arr1 =  ['a','b','c','d'],
    arr2 = ['a','b','c','k'],
    i = 0,
    equal = true;

if(arr1.length != arr2.length)
{
    equal = false;
} else {
    for(i;i<arr1.length;i+=1) {
        if(arr1[i] != arr2[i]) {
            equal = false;
            break;
        }
    }
    console.log(equal);
}