// Write a function to count the number of div elements on the web page
// this code counts the div tags of the page where is loaded

function count() {
    var counter = document.getElementsByTagName('div').length;
    return counter;
}

var result = count();
console.log(result);