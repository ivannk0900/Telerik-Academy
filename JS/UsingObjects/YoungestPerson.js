// Write a function that finds the youngest person in a given array of people
// and prints his/hers full name
// Each person has properties firstname, lastname and age.

function Person(fname,lname,age) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;

    this.fullName = function() {
        return this.firstName + ' ' + this.lastName;
    }
}

var ivan =  new Person('ivan','ivanov',11),
    gosho =  new Person('gosho','georgiev',14),
    mite = new Person('mite' ,'mitkov', 16);

var arr = [ivan,gosho,mite];

var youngestPerson =  new Person('','',100),
    i =0;

for(i; i < arr.length; i+=1) {

    if(arr[i].age<youngestPerson.age) {

        youngestPerson.firstName = arr[i].firstName;
        youngestPerson.lastName = arr[i].lastName;
        youngestPerson.age = arr[i].age;
    }
}

console.log(youngestPerson.fullName());