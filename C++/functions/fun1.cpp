#include <iostream>
using namespace std;

void callHim(string name, int age);

int main(){
        callHim("James", 20);
    return 0;
}

void callHim(string name, int age){
    cout<<"Hello "<<name<<" your "<<age<<" years old"<<endl;
}