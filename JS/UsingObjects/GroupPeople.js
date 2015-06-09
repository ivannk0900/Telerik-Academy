//  Write a function that groups an array of people by age, first or last name.
// The function must return an associative array,
// with keys - the groups, and values - arrays with people in this groups
// Use function overloading (i.e. just one function)

function Person(fname,lname,age) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;

    this.fullName = function() {
        return this.firstName + ' ' + this.lastName;
    }

    this.toString = function() {
        return this.firstName + ' ' + this.lastName + ' ' + this.age;
    }
}
var p1 =  new Person('gosho','ivanov',11),
    p2 =  new Person('ivan','ivanov',11),
    p3 =  new Person('pesho','ivanov',18),
    p4 =  new Person('gosho','georgiev',11),
    p5 = new Person('mite' ,'mitkov', 16)
    arr = [p1,p2,p3,p4,p5];

function groupBy(arr, keys) {

    var map = {};
    switch (keys) {
        case 'age': {
            for(var j=0; j < arr.length; j+=1) {    // creates the values(empty arrays) of all keys
               if(map[arr[j].age] == undefined) {
                   map[arr[j].age] = [];
               }
            }

            for( var i=0; i < arr.length; i +=1) {   // adds the persons to appropriate keys
                map[arr[i].age].push(arr[i]);
            }

            for (var key in map) {                  // prints the arrays with grouped persons by key
                console.log(map[key].toString());
            }


        } break;
        case 'firstName': {

            for(var j=0; j < arr.length; j+=1) {    // creates the values(empty arrays) of all keys
                if(map[arr[j].firstName] == undefined) {
                    map[arr[j].firstName] = [];
                }
            }

            for( var i=0; i < arr.length; i +=1) {   // adds the persons to appropriate keys
                map[arr[i].firstName].push(arr[i]);
            }

            for (var key in map) {                  // prints the arrays with grouped persons by key
                console.log(map[key].toString());
            }
        } break;
        case 'lastName': {
            for(var j=0; j < arr.length; j+=1) {    // creates the values(empty arrays) of all keys
                if(map[arr[j].lastName] == undefined) {
                    map[arr[j].lastName] = [];
                }
            }

            for( var i=0; i < arr.length; i +=1) {   // adds the persons to appropriate keys
                map[arr[i].lastName].push(arr[i]);
            }

            for (var key in map) {                  // prints the arrays with grouped persons by key
                console.log(map[key].toString());
            }
        } break;
        default: {console.log('Invalid key !')} break;
    }

}

groupBy(arr,'lastName');