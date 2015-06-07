// Write a function that reverses the digits of given decimal number.

    var input = 123.45,
    inputStr,
    result = '',
    i;

function reverse(input) {
    inputStr=input.toString();

    for(i=inputStr.length-1;i>=0;i-=1) {
        result+=inputStr[i];
    }
    return result;
}

console.log(reverse(input));