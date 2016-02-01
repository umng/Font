using System;
using System.Collections.Generic;
using System.Text;

namespace Font
{
    public class calculate
    {
        public string answer = "";

        public string Character = "";

        public void calculated(string text,string character,string size,string bold,string italic,string underline, int length)
        {
            answer = "";
            char[] content = new char[1];
            content = text.ToCharArray();

            Character = character;
            Character.ToCharArray();

            for (int m = 0; m < length ; m++)
            {
                string A_ = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                A_.ToCharArray();

                //Alphabets
                if (content[m] ==A_[0])
                {
                    alphabet_A();
                }
                if (content[m] == A_[1])
                {
                    alphabet_B();
                }
                if (content[m] == A_[2])
                {
                    alphabet_C();
                }
                if (content[m] == A_[3])
                {
                    alphabet_D();
                }
                if (content[m] == A_[4])
                {
                    alphabet_E();
                }
                if (content[m] == A_[5])
                {
                    alphabet_F();
                }
                if (content[m] == A_[6])
                {
                    alphabet_G();
                }
                if (content[m] == A_[7])
                {
                    alphabet_H();
                }
                if (content[m] == A_[8])
                {
                    alphabet_I();
                }
                if (content[m] == A_[9])
                {
                    alphabet_J();
                }
                if (content[m] == A_[10])
                {
                    alphabet_K();
                }
                if (content[m] == A_[11])
                {
                    alphabet_L();
                }
                if (content[m] == A_[12])
                {
                    alphabet_M();
                }
                if (content[m] == A_[13])
                {
                    alphabet_N();
                }
                if (content[m] == A_[14])
                {
                    alphabet_O();
                }
                if (content[m] == A_[15])
                {
                    alphabet_P();
                }
                if (content[m] == A_[16])
                {
                    alphabet_Q();
                }
                if (content[m] == A_[17])
                {
                    alphabet_R();
                }
                if (content[m] == A_[18])
                {
                    alphabet_S();
                }
                if (content[m] == A_[19])
                {
                    alphabet_T();
                }
                if (content[m] == A_[20])
                {
                    alphabet_U();
                }
                if (content[m] == A_[21])
                {
                    alphabet_V();
                }
                if (content[m] == A_[22])
                {
                    alphabet_W();
                }
                if (content[m] == A_[23])
                {
                    alphabet_X();
                }
                if (content[m] == A_[23])
                {
                    alphabet_Y();
                }
                if (content[m] == A_[24])
                {
                    alphabet_Z();
                }
            }

        }










        //Definitions

private void alphabet_A()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += "  ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 3 | i == 5)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 4 | i == 6 | i == 7 | i == 8)
        {
            answer += "  ";
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 2 | i == 3 | i == 4 | i == 5 | i == 6)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 7 | i == 8)
        {
            answer += "  ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 1 | i == 7)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 2 | i == 3 | i == 5 | i == 5 | i == 6 | i == 8)
        {
            answer += "  ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += "  ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

}

private void alphabet_B()
{
    //line 1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 )
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 )
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }
}

private void alphabet_C()
{
    //line 1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 )
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 )
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }
}

private void alphabet_D()
{
    //line 1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 2
    for (int i = 0; i < 9; i++)
    {
        if (i == 2 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 3
    for (int i = 0; i < 9; i++)
    {
        if (i == 2 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }



    //line 4
    for (int i = 0; i < 9; i++)
    {
        if (i == 2 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }


    //line 5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }
}

private void alphabet_E()
{
    //line 1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 )
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }



    //line 4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }


    //line 5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }
}

private void alphabet_F()
{
    //line 1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }



    //line 4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }


    //line 5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }
}

private void alphabet_G()
{
    //line 1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }



    //line 4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 4 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }


    //line 5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 8)
        {
            answer += Character[0];
        }
        if ( i == 5 | i == 6 | i == 7 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }
}

private void alphabet_H()
{
    //line 1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8 )
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }



    //line 4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }


    //line 5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }
}

private void alphabet_I()
{
    //line 1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 2
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }


    //line 3
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }




    //line 4
    for (int i = 0; i < 9; i++)
    {
        if (i == 4 )
        {
            answer += Character[0];
        }
        if ( i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }


    //line 5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }
}

private void alphabet_J()
{
    //line 1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }

        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 2
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }


    //line 3
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }




    //line 4
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }


    //line 5
    for (int i = 0; i < 9; i++)
    {
        if (i == 1 | i == 2 | i == 3 | i == 4 )
        {
            answer += Character[0];
        }
        if (i == 0 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }
}

private void alphabet_K()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8 )
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 6)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 3)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 6)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }
}

private void alphabet_L()
{
    //line 1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }

    //line 2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }


    //line 3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }




    //line 4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }



    //line 5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n";
        }
    }
}

private void alphabet_M()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 2 | i == 6 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 3 | i == 4 | i == 5 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 4 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }
}

private void alphabet_N()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 2 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 4 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 6 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }
}

private void alphabet_O()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }
}

private void alphabet_P()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 )
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

}

private void alphabet_Q()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 4 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 5 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-6
    for (int i = 0; i < 9; i++)
    {
        if ( i == 7)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-7
    for (int i = 0; i < 9; i++)
    {
        if (i == 8)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

}

private void alphabet_R()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 3)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 5)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-6
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 7)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


}

private void alphabet_S()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 )
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 8)
        {
            answer += Character[0];
        }
        if ( i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }



    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

}

private void alphabet_T()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }



    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

}

private void alphabet_U()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 1 | i == 7)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }



}

private void alphabet_V()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 1 | i == 7)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 2 | i == 6)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 3 | i == 4 | i == 5 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 3 | i == 5)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 4 | i == 6 | i == 7 | i == 8 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 4 )
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }



}

private void alphabet_W()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 4 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 2 | i == 6 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 3 | i == 4 | i == 5 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


}

private void alphabet_X()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 2 | i == 6 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 3 | i == 4 | i == 5 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 4 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 2 | i == 6 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 3 | i == 4 | i == 5 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


}

private void alphabet_Y()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if ( i == 2 | i == 6 )
        {
            answer += Character[0];
        }
        if ( i == 0 | i == 1 | i == 3 | i == 4 | i == 5 | i == 7 | i == 8 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if ( i == 4 )
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


}

private void alphabet_Z()
{
    //line A-1
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-2
    for (int i = 0; i < 9; i++)
    {
        if (i == 7)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-3
    for (int i = 0; i < 9; i++)
    {
        if (i == 4)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }


    //line A-4
    for (int i = 0; i < 9; i++)
    {
        if (i == 1)
        {
            answer += Character[0];
        }
        if (i == 0 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8 )
        {
            answer += " ";
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }



    //line A-5
    for (int i = 0; i < 9; i++)
    {
        if (i == 0 | i == 1 | i == 2 | i == 3 | i == 4 | i == 5 | i == 6 | i == 7 | i == 8)
        {
            answer += Character[0];
        }
        if (i == 8)
        {
            answer += "\n\n\n";
        }
    }

}




    }
}
