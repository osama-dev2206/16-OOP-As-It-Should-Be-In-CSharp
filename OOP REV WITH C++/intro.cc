#include <iostream>
#include <string>
using namespace std;

int x =10;
void method()
{

}


class clsPerson
{
    // all memeber are private by default
    string name; // --> data member
    short age;   // ==> data member

    string PriGetAge() // Member Method (function)
    {
        return this->name;
    }

public:            // ==> you can access class memebers in class scope or outside the class scope
    void GetName() // Member Method
    {
        cout << "The name is : " << name << "\nThe Age is: " << age << endl;
    }

protected: // => accessible in sub class only (the class that inherits this class)
    void Pro()
    {
        cout << "Iam Protected!\n";
    }

public:
    float Balance;

private: 
    int bala;

public: // Controls the data member (read only!)
        // i can change the data member name withoud breaking the code (easy to maintain)
    string GetBalance()const // ==> read only ( you can get the the value but you cann't edit it )
    {
        return to_string(bala);
    }

    void SetBalance(int val)
    {
        if(val>=0 && bala<val)
        bala=val; 
    }

    private:
    string _id ;

    public:
    string GetId(){return _id; }

};

void tests(clsPerson p)
{
    p.Balance = 0;
    p.GetBalance();
}

void tests2(clsPerson p)
{
    p.Balance = 0;
    p.GetBalance();
}

int main()
{
    clsPerson p;
    ///  p.PriGetAge() ; ==> in accesssible method (because it is private method )

    p.GetName(); // i could access this method in main as it is public method

    // p.Pro(); ==> inaccessible as it is protected method member

    p.Balance = -100;

    tests(p);
    tests2(p);

    p.GetBalance();

    p.GetId(); 
   
     ::x =-10;


}