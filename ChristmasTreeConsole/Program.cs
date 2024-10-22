
// track
bool f =true;

int h = 10;

while (true)
{

    for (int i = 0; i < h; i++)
    {
       
        for (int j = 0; j < h + i; j++)
        {
            if (j < h - 1 - i)
                Console.Write("  ");
            else
            {
                if (i != 0 && i != h - 1)
                {

                   
                    if (j % 3 == 0 && i % 2 == 0)
                    { 
                        if(f)
                        {
                            Console.Write("0 ");
                        }
                        else
                        {
                            Console.Write("p ");
                        }
                        continue; 
                    }
                    else
                    { Console.Write("* "); continue; }
                }

                Console.Write("* ");
            }


        }
        Console.WriteLine();
    }
    Thread.Sleep(50);
    Console.Clear();
    f= !f; 
   
}

