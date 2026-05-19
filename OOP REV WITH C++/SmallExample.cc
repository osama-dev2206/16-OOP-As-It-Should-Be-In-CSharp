#include <iostream>
using namespace std;

class Employee
{
private:
    string _Id;
    string _FirstName;
    string _LastName;
    string _Title;
    string _Email;
    string _Phone;
    int _Salary;
    string _Departement;

public:
    // parameterized constructor
    Employee(string id, string fname, string lname, string phone, int salary, string department)
    {
        _Id = id;
        _FirstName = fname;
        _LastName = lname;
        _Phone = phone;
        _Salary = salary;
        _Departement = department;
    };

    // Setter 
    void SetId(string id)
    {
        _Id=id;
    }

    void SetName(string fname,string lname)
    {
        _FirstName=fname;
    }

    // Getter
    string GetId(){return _Id;}
    string GetName(){return _FirstName+" "+_LastName ;} 
};

int main()
{
    Employee emp("2221","os","dd","1-39-1239020",9000,"sw");
    Employee emp2 = Employee("2221","os","dd","1-39-1239020",9000,"sw");



}
