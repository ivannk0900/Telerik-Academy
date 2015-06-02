
var arr = [4,1,6,2,5,3],
    i =0,
    j = 0,
    length = arr.length,
    minIndex = -1,
    minValue = 10000;




for ( i = 0; i < arr.length; i+=1)
{
    minValue = 10000;
    for ( j = i; j < arr.length; j++)
    {
        if(arr[j]<minValue)
        {
            minValue=arr[j];
            minIndex = j;
        }
    }
    temp = arr[i];
    arr[i] = minValue;
    arr[minIndex] = temp;
}

console.log(arr);