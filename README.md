# Bank CLI

A simple bank console application that allows users to create accounts and perform various transactions with their account.

Accounts are saved into file in **Database/FileDb.csv** (please do not edit file directly during runtime)

If program looks frozen, hit 'enter'

## Running application
Install .net 10 sdk

Entry point of program is Program.cs

Run ```dotnet run``` while in the current directory of Program.cs to start program

### Features
- Register to bank
- Login to bank
- Withdraw from account
- Deposit to account
- View account details
- Logout from account
- Prevent duplicate accounts (accounts with the same name)
- Prevent overdraft
- Prompt the user to confirm any withdrawal exceeding $5,000

### Color codes during runtime
- 🟦 Header
- ⬜ Neutral text
- 🟥 Error response
- 🟩 Success response