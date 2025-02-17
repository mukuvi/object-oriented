#include <iostream>

using namespace std;

class customer{
    public:
        float balance;
        string name;
        int amount;
        
        void printy(){
            cout<<"Enter your name: ";
            cin>>name;
            cout<<"Enter your balance: ";
            cin>>balance;

        }
        void withdrawal(){
            cout<<"Enter the amount: ";
            cin>>amount;
            balance = balance - amount;
            cout<<"Your current balance is: "<<balance<<endl;
        }

};
int main(){
        customer customer1;
        customer1.printy();
        customer1.withdrawal();
       
         
    return 0;
}