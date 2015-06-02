var a=13,b=22,c=3;

if(a>b) {
    if(a>c) {
        if(b>c) {
            console.log(a+' '+b+' '+c);
        } else {
            console.log(a+' '+c+' '+b);
        }
    }
} else if(b > c) {
    if(b>a) {
        if (a > c) {
            console.log(b + ' ' + a + ' ' + c);
        } else {
            console.log(b + ' ' + c + ' ' + a);
        }
    }
}
else {
    if(c>a) {
        if(c>b) {
            if(a>b) {
                console.log(c+ ' ' + a + ' ' + b);
            }
            else {
                console.log(c+ ' ' + b + ' ' + a);
            }
        }
    }
}
