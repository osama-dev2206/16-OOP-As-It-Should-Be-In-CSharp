#include <iostream>
using namespace std;

class test
{
    struct stData
    {
        string name;
        short age;
    };

    stData data;

public:
    test(string name, short age, string id)
    {
        data.name = name;
        data.age = age;
        in = InnerClass(name, id);
    }

    class InnerClass
    {
    private: // outer class cann't access the private data members
        string name;
        string id;

    public:
        InnerClass(string name, string id)
        {
            this->name = name;
            this->id = id;
        }

        void Print(test t)
        {
            cout << this->name << endl;
            cout << this->id << endl;
            cout << this << endl;
        }
    };

    InnerClass in = InnerClass("", "");
    static int x;
    void tst()
    {
        //// in.id="s"; member "test::InnerClass::id" (declared at line 26) is inaccessible
        this->x = 10; // you cann't use this pointer with static data membes
        in.Print(*this);   // public method in inner class you can access it (i have passed the current object as a paramter to print function )
    }

    static void GetInfo()
    {
        cout << x << endl;
      
    }
};
int test::x = 10;

int main()
{
    test t("", 0, "");

}