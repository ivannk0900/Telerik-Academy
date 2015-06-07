// Write a function that checks if the element at given position in given array
// of integers is bigger than its two neighbours (when such exist).

function larger(arr,position) {


    if(position===0||position===arr.length-1) {
        return false;
    } else if(position<0||position>arr.length-1) {
        return false;
    } else {
        if (arr[position - 1] < arr[position] && arr[position] > arr[position + 1]) {
            return true;
        }
    }
}



// problem 7 Write a function that returns the index of the first element
// in array that is larger than its neighbours or -1, if there’s no such element.
// Use the function from the previous exercise.


function firstLarger(arr) {
    var i=0;
    for(i;i<arr.length;i+=1) {
        if(larger(arr,i)) {
            return i;
        }
    }
    return -1;
}
var arr = [1,2,3,2,1,2,35,3];
console.log('problem 6: '+larger(arr,2));
console.log('problem 7: position: '+ firstLarger(arr));