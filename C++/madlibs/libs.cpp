#include <iostream>
using namespace std;

int main(){
    string color, pluralNoun, celebrity;
    cout<<"Enter a color: ";
    getline(cin, color);
    cout<<"Enter pluralNoun: ";
    getline(cin, pluralNoun);
    cout<<"Enter a celebrity";
    getline(cin, celebrity);

    cout<<"Roses are "<<color<<endl;
    cout<<pluralNoun<<" are blue"<<endl;
    cout<<"I love "<<celebrity<<endl;
    return 0;
}