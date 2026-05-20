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

class Sub2 : protected SubClass ///-> no no can see what i have inherited except the sub class of this class 
{

    void Test()
    {
        SubClass::ProtectedMethod(); // from super class (the first class) --> i could i access it bcz the main super is inherted as public inhertance mode 
    }
};

class clsPerson
{
private:
    string _Name;
    short _Age;

public:
    // parametrized constructor
    clsPerson(string name, short age)
    {
        _Name = name;
        _Age = age;
        cout << "Hello Iam Paramterized Constructor\n";
    }

    clsPerson()
    {
        cout << "Hello Iam Default Constructor Of Super Class\n";
    }
    // get
    string GetName()
    {
        return _Name;
    }

    short GetAge()
    {
        return _Age;
    }

    void print()
    {
        cout << "name: " << _Name << endl;
        cout << "age: " << _Age << endl;
    }
};

class Student : public clsPerson
{
private:
    string _Id;

public:
    Student()
    {
        cout << "iam the constructor of sub class\n";
    };

    // intialized the super class constructor
    Student(string Id, string Name, short Age) : clsPerson(Name, Age)
    {
        _Id = Id;
        cout << "Hello Iam Sub Class\n";
    }

    // Override print function ( have the same signture of the method in base class,have the same parameters but with different implementation )
    void print()
    {
        // to access the overriden function
        clsPerson::print();
        cout << "Id: " << _Id << endl;
    }
};

int main()
{
    SubClass sub;

    sub.PublicMethod();    // super class
    sub.PublicSubMethod(); // sub class

    sub.PublicMethod();



    Sub2 r;
    //r.PublicMethod(); // bcz protected inhertance mode 

    // Student s1("2415", "osama", 20);

    // clsPerson p("osama", 20);

    // cout<<"\nSuper:\n";
    // p.print(); // call the method from super class
    // s1.clsPerson::print();

    // cout<<"\nSub:\n";
    // s1.print(); // class the same method from sub class
}