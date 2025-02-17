#include <iostream>
using namespace std;

class Book {
    public:
        string title;
        string author;
        int pages;
};

int main(){

    Book book1;
    book1.title = "Harry porter";
    book1.author = "Jk rowling";
    book1.pages = 400;

    Book book2;
    book2.title = "Blossoms of savannah";
    book2.author = "Ole kulet";
    book2.pages = 500;
    cout<<book1.title<<endl;
    cout<<book2.author<<endl;


    return 0;
}