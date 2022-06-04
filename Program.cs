using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int contor_player_1 = 0;
            int contor_player_2 = 0;
            Console.WriteLine("Player 1:");
            Console.WriteLine("Draw cards till you hit at least 15 points!");
            while(contor_player_1<21)
            {
                Card card = new Card(i);
                card.Display();
                int card_value = card.Card_Value(i);
                if (card_value == 11)
                {
                    if ((contor_player_1 + 11) > 21)
                    {
                        contor_player_1 += 1;
                    }
                    else
                    {
                        contor_player_1 += card_value;
                    }
                }
                else
                {
                    contor_player_1 += card_value;
                }
                i++;
                if(contor_player_1>14 && contor_player_1<21)
                {
                    Console.WriteLine("Player 1 has {0} points", contor_player_1);
                    Console.WriteLine("Do you want to draw more cards?");
                    Console.WriteLine("Respond with Yes or No.");
                    string decision = Console.ReadLine();
                    if(decision=="Yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Player 1 has {0} points", contor_player_1);
                }
            }
            Console.WriteLine("Player 2:");
            Console.WriteLine("Draw cards till you hit at least 15 points!");
            while (contor_player_2 < 21)
            {
                Card card = new Card(i);
                card.Display();
                int card_value = card.Card_Value(i);
                if (card_value == 11)
                {
                    if ((contor_player_2 + 11) > 21)
                    {
                        contor_player_2 += 1;
                    }
                    else
                    {
                        contor_player_2 += card_value;
                    }
                }
                else
                {
                    contor_player_2 += card_value;
                }
                i++;
                if (contor_player_2 > 14 && contor_player_2<21)
                {
                    Console.WriteLine("Player 2 has {0} points", contor_player_2);
                    Console.WriteLine("Do you want to draw more cards?");
                    Console.WriteLine("Respond with Yes or No.");
                    string decision = Console.ReadLine();
                    if (decision == "Yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Player 2 has {0} points", contor_player_2);
                }
            }

            if (contor_player_1<=21 && contor_player_2<=21 && contor_player_1==contor_player_2)
            {
                Console.WriteLine("It is a draw");
            }
            else
            {
                if (contor_player_1 <= 21 && contor_player_1 > contor_player_2)
                {
                    Console.WriteLine("Player 1 is the winner with {0} points", contor_player_1);
                }
                else
                {
                    if (contor_player_2 <= 21 && contor_player_2 > contor_player_1)
                    {
                        Console.WriteLine("Player 2 is the winner with {0} points", contor_player_2);
                    }
                    else
                    {
                        if (contor_player_1 <= 21 && contor_player_2 > 21)
                        {
                            Console.WriteLine("Player 1 is the winner with {0} points", contor_player_1);
                        }
                        else
                        {
                            if (contor_player_2 <= 21 && contor_player_1 > 21)
                            {
                                Console.WriteLine("Player 2 is the winner with {0} points", contor_player_2);
                            }
                            else
                            {
                                if (contor_player_1 > 21 && contor_player_2 > 21)
                                {
                                    if (contor_player_1 - 21 < contor_player_2 - 21)
                                    {
                                        Console.WriteLine("Player 1 is the winner with {0} points", contor_player_1);
                                    }
                                    else
                                    {
                                        if (contor_player_2 - 21 < contor_player_1 - 21)
                                        {
                                            Console.WriteLine("Player 2 is the winner with {0} points", contor_player_2);
                                        }
                                        else
                                        {
                                            if(contor_player_1>21 && contor_player_2>21 && contor_player_1==contor_player_2)
                                            {
                                                Console.WriteLine("It is a draw");
                                            }
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                } 
            }
        }
    }
}
