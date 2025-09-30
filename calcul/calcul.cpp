// calcul.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    int choice;
    double a, b;
    setlocale(0, "UKR");
    cout << "Введіть числа" << endl; cin >> a >> b;
    cout << "Виберіть операцiю"<<endl;
    cout << "1-Віднімання"<<endl;
    cout << "2-Додавання"<<endl;
    cout << "3-Множення"<<endl;
    cout << "4-Ділення"<<endl;
    cin >> choice;
    switch (choice)
    {
    case 1: {
        substract(a, b);
        break;
    }case 2: {
        add(a, b);
        break;
    }case 3: {
        multiply(a, b);
        break;
    }case 4: {
        divide(a, b);
        break;
    }
    default:
        break;
    }
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
