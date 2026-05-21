#include <iostream>
using namespace std;

class clsCalac
{
    // you can type friend class anywhere in the class scope

private:
    int _x;
    int _y;
    int _a;

protected:
    int c;
    int d;

public:
    int l;
    int m;

public:
    clsCalac()
    {
        _x = 10;
        _y = 200;
        c = 19;
        d = 12;
        l = 1019293;
        m = 1412;
        _a = 213;
    }
  
    // you can declare your friend class anywhere in base class
    friend class clsPrint;  // --> so class 'clsPrint' can access all private & protected members of the class 
    void TryToAccessTheFriendClass()
    {
        clsPrint e;
        //e.pri; // you cann't access private data memebers of your friend class
        // relationship with one member who gives a care to the another member 
    }
};

class clsPrint
{
    private:
    string pri; 
public:
    void display(clsCalac c)
    {
        cout << c.c << endl;  // --> c is inaccessible (cuz it is protected member)
        cout << c._a << endl; // --> a is inaccessible (cuz it is protected data member)
        cout << c._x << endl; // --> _x is inaccessible (cuz it is private member)
        cout << c.l << endl;  // accessible as it is public data member
    }
};

int main()
{
    clsCalac v;
    clsPrint p;
    p.display(v);
}