var number = 123, str = '';

var hundreds = Math.floor(number/100),
    tens = Math.floor(number/10)%10,
    ones = number%10;


if(hundreds) {
    switch (hundreds){

        case 1: str+='one hundred '; break;
        case 2: str+='two hundred '; break;
        case 3: str+='three hundred '; break;
        case 4: str+='four hundred '; break;
        case 5: str+='five hundred '; break;
        case 6: str+='six hundred '; break;
        case 7: str+='seven hundred '; break;
        case 8: str+='eight hundred '; break;
        case 9: str+='nine hundred '; break;
    }
}
if(hundreds && tens==0) {
    switch (ones) {
        case 0: str+=' '; break;
        case 1: str+='and one'; break;
        case 2: str+='and two '; break;
        case 3: str+='and three '; break;
        case 4: str+='and four '; break;
        case 5: str+='and five '; break;
        case 6: str+='and six '; break;
        case 7: str+='and seven '; break;
        case 8: str+='and eight '; break;
        case 9: str+='and nine '; break;
    }
}


if(hundreds && tens==1) {
    switch (ones) {
        case 0: str+='and ten'; break;
        case 1: str+='and eleven'; break;
        case 2: str+='and twelve '; break;
        case 3: str+='and thirteen '; break;
        case 4: str+='and fourteen '; break;
        case 5: str+='and fifteen '; break;
        case 6: str+='and sixteen '; break;
        case 7: str+='and seventeen '; break;
        case 8: str+='and eighteen '; break;
        case 9: str+='and nineteen '; break;
    }
}

if(hundreds && ones==0)
{
    switch (tens) {
        case 2: str+='and twenty'; break;
        case 3: str+='and thirty'; break;
        case 4: str+='and forty'; break;
        case 5: str+='and fifty'; break;
        case 6: str+='and sixty'; break;
        case 7: str+='and seventy'; break;
        case 8: str+='and eighty'; break;
        case 9: str+='and ninety'; break;

    }
}

if(hundreds && ones!=0 && tens>=2) {
    switch (tens) {
        case 2: str+= 'twenty-'; break;
        case 3: str+=' thirty-'; break;
        case 4: str+=' forty-'; break;
        case 5: str+=' fifty-'; break;
        case 6: str+=' sixty-'; break;
        case 7: str+=' seventy-'; break;
        case 8: str+=' eighty-'; break;
        case 9: str+=' ninety-'; break;
    }
    switch (ones) {
        case 1: str+='one'; break;
        case 2: str+= 'two'; break;
        case 3: str+='three'; break;
        case 4: str+='four'; break;
        case 5: str+='five'; break;
        case 6: str+='six'; break;
        case 7: str+='seven'; break;
        case 8: str+='eight'; break;
        case 9: str+='nine'; break;
    }
}

/*
if(hundreds===0 && tens===1)
{
    switch (ones) {
        case 0: str+='ten'; break;
        case 1: str+='eleven'; break;
        case 2: str+='twelve '; break;
        case 3: str+='thirteen '; break;
        case 4: str+='fourteen '; break;
        case 5: str+='fifteen '; break;
        case 6: str+='sixteen '; break;
        case 7: str+='seventeen '; break;
        case 8: str+='eighteen '; break;
        case 9: str+='nineteen '; break;
    }
}

*/
if(hundreds===0 && ones===0)
{
    switch (tens) {
        case 2: str+='twenty '; break;
        case 3: str+='thirty '; break;
        case 4: str+='forty '; break;
        case 5: str+='fifty '; break;
        case 6: str+='sixty '; break;
        case 7: str+='seventy '; break;
        case 8: str+='eighty '; break;
        case 9: str+='ninety '; break;
    }
}

if(hundreds===0 && tens===0)
{
    switch (ones) {
        case 0: str+='zero '; break;
        case 1: str+='one '; break;
        case 2: str+='two '; break;
        case 3: str+='three '; break;
        case 4: str+='four '; break;
        case 5: str+='five '; break;
        case 6: str+='six '; break;
        case 7: str+='seven '; break;
        case 8: str+='eight '; break;
        case 9: str+='nine '; break;
    }
}

if(hundreds===0 && tens==1 )
{
    switch (ones) {
        case 0: str+='ten'; break;
        case 1: str+='eleven'; break;
        case 2: str+='twelve '; break;
        case 3: str+='thirteen '; break;
        case 4: str+='fourteen '; break;
        case 5: str+='fifteen '; break;
        case 6: str+='sixteen '; break;
        case 7: str+='seventeen '; break;
        case 8: str+='eighteen '; break;
        case 9: str+='nineteen '; break;
    }
}

if(hundreds===0 && tens!=1 && tens != 0 && ones!=0)
{
    switch (tens) {
        case 2: str+='twenty-'; break;
        case 3: str+='thirty-'; break;
        case 4: str+='forty-'; break;
        case 5: str+='fifty-'; break;
        case 6: str+='sixty-'; break;
        case 7: str+='seventy-'; break;
        case 8: str+='eighty-'; break;
        case 9: str+='ninety-'; break;
    }
    switch (ones) {
        case 1: str+='one'; break;
        case 2: str+='two '; break;
        case 3: str+='three '; break;
        case 4: str+='four '; break;
        case 5: str+='five '; break;
        case 6: str+='six '; break;
        case 7: str+='seven '; break;
        case 8: str+='eight '; break;
        case 9: str+='nine '; break;
    }
}

console.log(str);
