#include <iostream>
using namespace std;

class Person{
    public:
    string name;
    string school;
    int age;
    float gpa;
    Person(string Aname, string Aschool, int Aage, float Agpa){
        name = Aname;
        school = Aschool;
        age = Aage;
        gpa = Agpa;
        }
};

int main(){
    Person Person1("James","University of Eldoret",20, 4.5);
    Person Person2("John", "University of Nairobi", 22, 4.0);
    cout<<Person1.name<<endl;



    return 0;
}