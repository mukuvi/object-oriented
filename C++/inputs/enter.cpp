#include <iostream>
using namespace std;

int main(){
    int age;
    string name;
    cout<<"Enter your name: ";
    getline (cin, name);
    cout<<"Enter your age: ";
    cin>>age;
    cout<<"Your "<<name<< " and your "<<age<<"years old"<<endl;


    return(0);
}