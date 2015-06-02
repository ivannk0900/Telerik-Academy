var a=1,b=5,c=6;

if(a===0) {
    if(b===0) {
        if(c===0) {
            console.log('x belongs to - inf to + inf');
        } else {
            console.log('No real roots')
        }
    } else {
        console.log('x= ' + -c/b);
    }
} else {
    var d = b*b - 4*a*c;
    console.log('x1= ' + (-b+Math.sqrt(d))/2*a );
    console.log('x2= ' + (-b-Math.sqrt(d))/2*a );
}