#include <iostream>
using namespace std;

// super class
class Super
{
private:
    string PriStr;

public:
    void PublicMethod()
    {
        cout << " Iam public\n";
    }

protected:
    void ProtectedMethod()
    {
        cout << "Iam Protected\n";
    }
};

// sub class will inherit all data members , methods from super class
class SubClass : public Super
{
private:
    string str;

public:
    void PublicSubMethod()
    {
        cout << "\nHello from sub class \n";
    }

    protected:
    void ProSubMethod()
    {
        cout << "\nHello from sub class \n";
    }
};


int main()
{
    
}