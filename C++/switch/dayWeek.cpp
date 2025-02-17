#include <iostream>
using namespace std;

string dayNum(int numDate){
    string theDate;
    
    switch(numDate){
        case 0:
        theDate = "Sunday";
        break;

        case 1:
        theDate = "Monday";
        break;

        case 2:
        theDate = "Tuesday";
        break;

        case 3:
        theDate = "Wednesday";
        break;

        case 4:
        theDate = "Thurday";
        break;

        case 5:
        theDate = "Friday";
        break;

        case 6:
        theDate = "Saturday";
        break;

        default:
        theDate = "Invalid date";

    }
    cout<<theDate<<endl;

    return theDate;
}

int main(){
    dayNum(0);
    return 0;
}