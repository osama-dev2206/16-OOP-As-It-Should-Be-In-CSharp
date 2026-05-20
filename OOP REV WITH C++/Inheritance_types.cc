#include <iostream>
using namespace std;
// Single Inheritance

class Super
{
    ////
    /////
    ///
};

class Sub : private Super
{
};

class SubOfSub : Sub
{
    /////
    ///
    /// 
};

class A : Super
{
};
class B : Super
{
};
class C : Super
{
};

class super
{
    public:
    void SuperClass(){}
};

class sub : public super{
    public:
    void subClass()
    {

    }
};

int main()
{
    sub b;

    super * Up = & b; //up casting 
    //Up.subClass();
    Up->SuperClass(); 
}
