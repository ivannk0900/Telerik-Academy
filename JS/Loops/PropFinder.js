// Write a script that finds the lexicographically
// smallest and largest property in document, window
// and navigator objects

var min= 0,
    max= 0;

console.log('window');

for(var property in window){
    if(!min){
        min = property;
    }
    if(!max){
        max = property;
    }

    if(property < min){
        min = property;
    }

    if(property > max){
        max = property;
    }
}


console.log('min: ' + min);
console.log('max: ' + max + '\n\r');


console.log('navigator');

for(var property in navigator){
    if(!min){
        min = property;
    }
    if(!max){
        max = property;
    }

    if(property < min){
        min = property;
    }

    if(property > max){
        max = property;
    }
}


console.log('min: ' + min);
console.log('max: ' + max + '\n\r');