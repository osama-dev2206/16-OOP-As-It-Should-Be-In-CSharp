#include <iostream>
using namespace std;

// forward declare clsT so its member can be friended
class clsT;

class Example
{

private:
    string str;

public:
    string PublicStr;

protected:
    string ProStr;

    friend void FriendFunction();
    friend class MyFriend;

};

// Try Friend Class
class MyFriend
{
    void TestFri()
    {
        Example e;
        e.PublicStr; // public
        e.str;       // private
        e.ProStr;    // protected
    }
};

// Try Friend Function
void FriendFunction()
{
    Example e;
    e.PublicStr; // public
    e.str;       // private
    e.ProStr;    // protected
}

// Try Friend Function Inside Another Class
