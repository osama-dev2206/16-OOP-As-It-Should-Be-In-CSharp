#include <iostream>
using namespace std;

void Count()
{
    static int count = 0;
    count++;
    cout << count << endl;
}

void Count2()
{
    int count = 0;
    count++;
    cout << count << endl;
}

class Static
{   public:
    static int x;

 
    Static()
    {
        x=10;
        this->x=10; 
    }

    void NonStatic()
    {
        x=100;
    }
    static void StaticMethod()
    {
        x=1900;
    }
};
int Static::x = 10; // static data memeber, should be intialized outside class

int main()
{
    // Static
   


    Static s ; 
    cout<< Static::x<<endl; 

}