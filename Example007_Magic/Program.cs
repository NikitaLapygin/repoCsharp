// Set cursor position with + shows cursor in set coordinates
Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

//Show three apices of triangle
Console.SetCursorPosition (xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

//Start of the drawing
int x=xa, y=ya;
int count = 0;
while (count<1000000)
{ 
    int what = new Random().Next(0,3); //Choose a random apex of previously set triangle
    if (what == 0)
    {
        x = (x+xa)/2; //set cursor to the middle of interval between triangle apex 1 and current position
        y = (y+ya)/2;
    }

    if (what == 1)
    {
        x = (x+xb)/2; 
        y = (y+yb)/2;
    }

    if (what == 2)
    {
        x = (x+xc)/2; 
        y = (y+yc)/2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("*");
    count ++;
}



