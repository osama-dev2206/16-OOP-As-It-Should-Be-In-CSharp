#include <iostream>
using namespace std;

class clsCard
{
    int _Id;
    string _Name;

    // constructor ==> special method that is called auto when you create an object of class
    // if the constructor is private you will not can create an object of this class
    // constructor ==> called implictly when you create object of class(if you didn't have declared it )
public:
    clsCard() // Default Constructor
    {
        _Id = -1;
        _Name = "";
    }

    // copy constructor
    clsCard(clsCard &OldObj)
    {
        // Take The Data From Exisiting Object (of the same data type) To The New Object
        cout << "\nHi Iam Copy Constructor!\n";
        _Id = OldObj._Id;
        _Name = OldObj._Name;
    }

    int GetCardId() { return _Id; }
    string GetName() { return _Name; }

    void SetId(int id) { _Id = id; }
    void SetName(string name) { _Name = name; }
};

class LinkedList
{
    class Node
    {
    public:
        int data;
        Node *Next;

        Node(int value)
        {
            data = value;
            Next = nullptr;
        };
    };

    Node *Head;
    Node *temp = Head;

public:
    LinkedList() // default constructor
    {
        Head = nullptr;
    };

    void InsertAtTheFirst(int value)
    {
        Node *NNode = new Node(value);

        if (Head == nullptr)
        {
            Head = NNode;
            NNode->Next = nullptr;
        }

        else
        {

            Head = Head->Next;
            delete temp;
        }
    }

    ~LinkedList() // Destructor ==> it is calling when an object is about to get out from memory
    {
        cout << "\nDestructor\n";
    }
};

// Dynamic Mempry Allocation ==> handeld By Dev No Garbage Collator

int main()
{
    clsCard t;
    t.SetId(190);
    t.SetName("Card109");
    cout << "Id For t: " << t.GetCardId() << endl;

    clsCard t2;

    t2 = t; // will call the copy constructor to copy the data from existing object to new object

    cout << "Id For t2: " << t2.GetCardId() << endl;

    LinkedList l;
    l.InsertAtTheFirst(10);

    LinkedList * Dy = new LinkedList();
    delete Dy; 
}