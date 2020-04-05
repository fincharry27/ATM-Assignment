#include <fstream>
#include <iostream>
#include <string>
#include <sstream>
using namespace std;
/*
 * ThreadATM.cpp
 *
 *
 *     	ATM Simulator just to get inital code working
 *      Account Number: 118118
 *      Pin Number: 1181
 *
 *      Description: It works
 *      Todo: Check if this actually works or I need to rework this thing again
 */

class Thread
{
	int StoreAcNumber = 18118;
	int StorePin = 1181;
	int StoreBalance = 50;
	int WithdrawAmmount;
	int MenuMoney;
		int Menu;

public:
	void StageAccountCheck(); //Enter Pin number and account number
	void StageMenu(); //Main menu for ATM
	void ReturnCard(); //Return Card
	void AccountBalance(); //Check how poor you are sorry bank balance

	//Todo: Implement below slightly better
	void WithdrawMoney(); //Withdraw cash
	void BalanceWithdraw(); //The actaul part where it withdraws your cash

};

void Thread::StageAccountCheck()
{
	int ACNumber; //Account Number
	int Pin; // Pin Number
	// Please enter account number and check if true or false. (Hard coded for now)
	cout << "Please enter your account number";
	cin >> ACNumber;
	// Enter Pin number
	cout << "Please enter your Pin Number";
	cin >> Pin;
	//Check if true or false.
	if (StoreAcNumber == ACNumber && StorePin == Pin)
	{
		cout << "Hello Your Name";
		StageMenu();
	}
	else
	{
		cout << "Youve entered incorect account number or Pin Number Please try again";
		StageAccountCheck();
	}
}

void Thread::StageMenu()
{
	//Main Menu for ATM
	//TODO: Remove temp menu when GUI is Implemented
	cout << "Please select an option";
	cout << "1 - Return Card";
	cout << "2 - Withdraw Cash";
	cout << "3 - Check your Balance";
	cin >> Menu;

	switch (Menu) {
	case 1:
		cout << "Return Card";
		ReturnCard();
	case 2:
		cout << "Withdraw Cash";
		WithdrawMoney();
	case 3:
		cout << "Check Balance";
		AccountBalance();
	default:
		cout << "Please select an option betwen 1 2 or 3";
	}
}

void Thread::ReturnCard()
{
	//TODO: Implement GUI relevant card
	cout << "Thank you for using Generic Bank";
	//ReturnCard
}

void Thread::AccountBalance()
{
	//TODO: Implement GUI relevant card
	cout << "Your Account balance is;";
		cout << StoreBalance;
	StageMenu();
}

void Thread::WithdrawMoney()
{
	//TODO: Implement GUI relevant card
	//TODO: Why the fuck is switch is fucked again

	cout << "How much should be Withdrawn";
	cout << "£10";
	cout << "£20";
	cout << "£40";
	cout << "£100";
	cout << "£500";

	switch (MenuMoney) {
	case 1:
		cout << "£10";
		WithdrawAmmount = 10;
		BalanceWithdraw();

	case 2:
		cout << "£20";
		WithdrawAmmount = 20;
		BalanceWithdraw();

	case 3:
		cout << "£40";
		WithdrawAmmount = 40;
		BalanceWithdraw();

	case 4:
		cout << "£100";
		WithdrawAmmount = 100;
		BalanceWithdraw();

	case 5:
		cout << "£500";
		WithdrawAmmount = 500;
		BalanceWithdraw();

	default:
	cout << "Please select an option from the Menu";

			// Add Invalid Input and chose
	}
}

void Thread::BalanceWithdraw()
{
	//Check Balance and withdarw money
	if (WithdrawAmmount > StoreBalance)
	{
		cout << "You do not have sufficent funds to withdraw cash";
		StageMenu();
	}

	else
	{
		cout << "Withdrawing Cash";
		cout << "Thank you for using Generic High Street Bank";
		StageMenu();
	}
}
