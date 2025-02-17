#include <iostream>
using namespace std;

int main(){
      
      int num = 3;
      double gpa = 4.5;
      string name = "james";
      int *Pnum = &num;
      cout<<gpa<<endl;

      cout<<*Pnum<<endl;//dereferencing a pointer
      cout<<*&name<<endl;
    return 0;
}