// Write a function that checks if a given object contains a given property.

function hasProperty(object,property) {

    return object.hasOwnProperty(property);
}

console.log(hasProperty([],'length'));