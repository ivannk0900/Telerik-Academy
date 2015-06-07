// Write a function that finds all the occurrences of word in a text.
//   The search can be case sensitive or case insensitive.

function find(text,word,sensitive) {
    var i= 0,
        counter = 0,
        args=[].slice.apply(arguments),
        allWords = args[0].split(' ');
    console.log(args[0]);

    for(i; i<allWords.length-2;i+=1) {
        if(args[2]==='sensitive')
        {
            if(allWords[i]===word)
            {
                counter+=1;
            }
        }
        else
        {
            if(allWords[i].toLowerCase()===word.toLowerCase())
            {
                counter+=1;
            }
        }

    }
    return counter;
}

var sens = find('abv abv abV jo sad err','abv','sensitive');
var insens = find('AbV abV abv jo sad err','abv');
console.log(sens);
console.log(insens);