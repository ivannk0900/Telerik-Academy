// Write a function that makes a deep copy of an object.
// The function should work for both primitive and reference types.

function Person(fname,lname,age,gender) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;
    this.gender = gender;

    this.fullName = function() {
        return this.firstName + ' ' + this.lastName;
    };
}

function copy(object) {
    var copied = {};

    for(var prop in object){
        copied[prop] = object[prop];
    }
    return copied;
}

var personIvan = new Person('Ivan','Ivanov',20,'male');
console.log(personIvan);

var copyIvan = copy(personIvan);
copyIvan.firstName = 'changed';
console.log(copyIvan);
