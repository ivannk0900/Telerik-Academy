 var arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
     element = 4;

 var min = 0, max = arr.length - 1, index = -1;
 while (min <= max) {
     var mid = min + (max - min) / 2;
     mid = Math.floor(mid);
     if (arr[mid] > element) {
         max = mid - 1;
     }
     else if (arr[mid] < element) {
         min = mid + 1;
     }
     else {
         index = mid;
         break;
     }
 }

 console.log('Index of element ' + element + ' is ' + index);