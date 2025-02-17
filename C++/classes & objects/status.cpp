#include <iostream>
using namespace std;

class student{
    public:
    string name;
    int age;
    float spendings;
    float pocket;
    void print(){
        cout<<"Enter your name: ";
        cin>>name;
        cout<<"Enter your age : ";
        cin>>age;
        cout<<"Your weekly spendings: ";
        cin>>spendings;
    }
    void currentAmount(){
        cout<<"Enter your pocket: ";
        cin>>pocket;
        pocket = pocket - spendings;
        cout<<"Your current amount is: "<<pocket<<endl;
    }
};
int main(){
    student student1;
    student1.print();
    student1.currentAmount();
    

    return 0;
}