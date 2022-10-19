//Isaiah Keith Ferguson
//10/18/22
//Odd or Even 
//The user will enter a number at we will output whether it is even or odd.
//Peer Reviewed by:

Console.Clear();

string programEnd = "";
double remainder = 0;
double total = 0;
double validnum = 0;
bool isNumber = true;
string num;


while(programEnd != "end"){
Console.WriteLine("Hello~! we will tell you if your number is odd or even!");
Console.WriteLine("Please enter a number:");

num = Console.ReadLine();
isNumber = double.TryParse(num, out validnum);

if(!isNumber){
    Console.WriteLine("Thats not a number.");
    Console.WriteLine("Type 'End' to end the program or any other input to replay");
}else
{
    if(remainder == (validnum % 2)){
    Console.WriteLine($"Your number {num} is even");
    Console.WriteLine("Type 'End' to end the program or any other input to replay");
   
}else
{
    Console.WriteLine($"Your number {num} is odd");
    total = (validnum % 2);
    Console.WriteLine("Type 'End' to end the program or any other input to replay");
}
}
programEnd = Console.ReadLine().ToLower();
}
