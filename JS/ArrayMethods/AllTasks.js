// Write a function for creating persons.
// Each person must have firstname, lastname, age and gender (true is female, false is male)
// Generate an array with ten person with different names, ages and genders

function Person(fname, lname, gender,age) {
    this.firstName = fname;
    this.lastName = lname;
    this.gender = gender;
    this.age = age;
}
function getRandomInt() {
    return Math.floor(Math.random() * 101);
}
function getRandomBool() {
    if(Math.floor(Math.random()*2)) {
        return true;
    }
    return false;
}

function createPerson() {
    return new Person('Name'+getRandomInt(),'Lname'+getRandomInt(),getRandomBool(),getRandomInt());
}



var arr = [],
    i=0;
for(i;i<10;i+=1) {
    arr.push(createPerson());
    console.log(arr[i]);
}
// end problem 1


console.log(' ');
console.log('Problem 3');
// problem 2
// Write a function that checks if an array
// of person contains only people of age (with age 18 or greater)

function checkAge(arr) {
    if(arr.every(function (person) {
            return (person.age > 18);
        })) {
        return true;
    }
    return false;
}

console.log(checkAge(arr));

// end problem 2


// problem 3
console.log(' ');
console.log('Problem 3');
// Write a function that prints all underaged persons of an array of person

function print(arr) {
    var under = [];
    arr.filter(function (person) {
        if(person.age<18) under.push(person);
    });
   under.forEach(function(person) {
       console.log(person);
   })
}

print(arr);
// end problem 3

console.log(' ');
console.log('Problem 4');
// problem 4
//  Write a function that calculates the average age of all females, extracted from an array of persons

function average(arr) {
    var female = [],
        average = 0;
    arr.filter(function (person) {
       if( person.gender == true) female.push(person);
    });

    female.forEach(function(person) {
        average+=person.age;
    });
    return 'Average female age: ' + (average/female.length).toFixed(2);
}

console.log(average(arr));
// end problem 4

console.log(' ');
console.log('Problem 5');
// problem 5
// Write a function that finds the youngest male person in a given array of people and prints his full name


// feature detection
if(!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i,
            len;
        for(i=0, len = this.length; i<len; i+=1) {
            if(callback(this[i], i.this)) {
                return this[i];
            }
        }
        return undefined;
    };
}

function youngestMale(arr) {

    var male = [];
    arr.filter(function (person) {
        if( person.gender == false) male.push(person);
    });

    male.sort(function (first, second) {        //changes original male array!

        return first.age - second.age;
    });

   return male.find(function(person) {  // returns the first person in the sorted male arr
            return person;
    });

}
console.log(youngestMale(arr));

// end problem 5


// problem 6
console.log(' ');
console.log('Problem 6');
// Write a function that groups an array of persons by first
// letter of first name and returns the groups as a JavaScript Object

var sorted = arr.reduce(function (obj, item) {

    if (obj[item.firstName[0]]) {
        obj[item.firstName[0]].push(item);
    } else {
        obj[item.firstName[0]] = [item];
    }
    return obj;
}, {});

console.log('Task 06:' + JSON.stringify(sorted));




