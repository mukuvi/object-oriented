#include <iostream>
using namespace std;

int main(){

    int num1;
    int num2;
    char op;

    cout<<"Enter First number: ";
    cin>>num1;
    cout<<"Enter operator: ";
    cin>>op;
    cout<<"Enter second number: ";
    cin>>num2;
    int result;

    if(op == '+'){
        result = num1 + num2;
    }else if (op == '-'){
        result = num1 - num2;
    }
    else if (op == '*'){
        result = num1 * num2;
    }else if (op == '/'){
        result = num1 / num2;
    }else{
        cout<<"Invalid operator";
    }
    cout<<result<<endl;

    return result;
}