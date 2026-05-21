#include <iostream>
using namespace std;

class clsPerson
{
    // this class will be abstract class if it has at least one pure virtual function
    virtual void print() = 0; // pure virtual function

    string name;
    short age;

public:
    clsPerson(string name, short age)
    {
        this->name = name;
        this->age = age;
    };

    void SetName(string name)
    {
        this->name = name;
    }

    void SetAge(short age)
    {
        this->age = age;
    }
    string GetName() const
    {
        return this->name;
    }

    short GetAge() const
    {
        return this->age;
    }
};

// you must override the pure virtual function other wise this class will be an abstract class also
class Student : public clsPerson
{
    string id;

public:
    Student(string name, short age, string id) : clsPerson(name, age)
    {

        this->id = id;
    }

    void print() override
    {
        cout << "Name: " << GetName() << endl;
        cout << "Age: " << clsPerson::GetAge() << endl;
        cout << "Student Id: " << this->id << endl;
    }
};

int main()
{
    Student s("oda",20,"245166");
    s.print();
}