#include <iostream>
using namespace std;

int calculat(int a, int b, int c){
    int result;
    if(a >= b && a >= c){
        result = a;
    }else if(b >= a && b >= c){
        result = b;
    }else if(c >= a && c >= b) {
        result = c;
    }else {
       result = false;
    }

      return result;
}

int main(){
     cout << calculat(5, 3 , 8)<<endl;
      

    return 0;
}