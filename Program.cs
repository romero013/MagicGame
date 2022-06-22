﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicGame
{
    class MagicGame
    {
        public int SecretNum, Start = 0, Finish = 100;
        public void StepLeft()
        {
            
        }
        public void StepRigth()
        {

        }
        public int IsNumCorrect(ref int SecretNum)
        {
            int _result = 0;
            Console.WriteLine("Это число {0}?\n(1 - меньше, 2 - больше, другое число - я угадал)", SecretNum);
            do
            {
                Console.WriteLine("Введите число: ");
                try
                    {
                        _result = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Не могу распознать ответ. Введите, пожалуйста, заново...");
                    }
            } while (_result == 0);


            if (_result == 1)
            {
                StepLeft();
            }
            else if (_result == 2)
                {
                    StepRigth();
                }
                else
                    GameOver();
            
            return _result;
        }
        public void GameOver()
        {
            Console.WriteLine("Congratulations!\n\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра начата!");
            MagicGame myGame = new MagicGame();
            myGame.Start = 0;
            myGame.Finish = 100;
            myGame.SecretNum = (myGame.Start + myGame.Finish) / 2;
            myGame.IsNumCorrect(ref myGame.SecretNum);
            myGame.StepLeft();
        }
    }
}
