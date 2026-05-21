#include <iostream>
using namespace std;

class Super
{
public:
    virtual void Function()
    {
        cout << "Hello From Super Class!\n";
    }
};

class Sub : public Super
{
public:
    void Function() override
    {
        cout << "Hello From Sub Class!\n";
    }
};

int main()
{
    Sub s;
    s.Function();

    Super s1;
    s1.Function();

    Super *U = &s;
    U->Function();  // late / dynamic binding 
}
