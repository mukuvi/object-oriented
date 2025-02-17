#include <iostream>
using namespace std;

int main(){

        bool isMale = true;
        bool isTall = false;
        if(isMale && isTall){
            cout<<"Your a tall a male"<<endl;
        }else if(isMale && !isTall){
            cout<<"Your a short male"<<endl;
        }else if(!isMale && isTall){
            cout<<"Your a tall lady"<<endl;
        }else if(!isMale && !isTall){
            cout<<"Your a short lady"<<endl;
        }else {
            cout<<"Your not human being"<<endl;
        }

    return 0;
}