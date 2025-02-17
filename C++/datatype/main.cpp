#include <iostream>
#include <cmath>//to use math functions
using namespace std;

int main(){
        string characterName = "james mukuvi ngandu";
        int characterAge = 20;
        char grade = 'A';
        float gpa = 4.0;
        double num = 6.8998;
        bool isEven = true;


        
        
    cout<<"Hello "<<characterName<<endl;
    cout << characterName<<" is "<<characterAge<<" years old"<<endl;
    cout<<characterName<<" scored "<<grade<< "and my gpa is " <<gpa<<endl;
    cout<<characterName.length()<<endl;
    cout<<characterName[3]<<endl;//accessing index
    //functios
    cout<<pow(2,5)<<endl;//math function
    cout<<sqrt(36)<<endl;// returns square of a number
    cout<<fmax(30, 45)<<endl;//shows the largest number

    return(0);
}