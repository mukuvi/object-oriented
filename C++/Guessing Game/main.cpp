#include <iostream>
using namespace std;

int main(){
    int luckyNum = 8;
    int guess;

    while (luckyNum != guess){
        cout<<"Enter the lucky number: ";
        cin>>guess;
    }
    cout<<"You won!"<<endl;
    return 0;
}