#include <iostream>
using namespace std;

class rectangle{
    private:
    float length;
    float width;
   
    public:
    void dimensions(float l, float w){
        length = l;
        width = w;
    }
    double perimeter();  
    
};

double rectangle::perimeter(){
    return 2 * (length + width);
      
        
}
int main(){
    rectangle rectangle1;
    rectangle1.dimensions(5.0, 5.0);
    cout<<"Perimeter: "<<rectangle1.perimeter()<<endl;
  return 0;
}