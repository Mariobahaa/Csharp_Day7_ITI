using System;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Answer A11 = new Answer("Cairo");
            Answer A12 = new Answer("Berlin");
            Answer A13 = new Answer("Paris");
            Answer A14 = new Answer("Tokyo");
            AnswerList C1 = new AnswerList();
            C1.addAnswer(A14); C1.addAnswer(A13);
            C1.addAnswer(A11); C1.addAnswer(A12);
            ChooseOneQuestion Q1 = new ChooseOneQuestion("What is the Capital of Egypt?", 3, C1);
            TrueFalseQuestion Q2 = new TrueFalseQuestion("China has the largest population?", 2);
            Answer A31 = new Answer("Saudi Arabia");
            Answer A32 = new Answer("Egypt");
            Answer A33 = new Answer("Ghana");
            Answer A34 = new Answer("Russia");
            AnswerList C3 = new AnswerList();
            C3.addAnswer(A34); C3.addAnswer(A33);
            C3.addAnswer(A31); C3.addAnswer(A32);
            ChooseAllQuestion Q3 = new ChooseAllQuestion("Which Countries are in Africa?", 6, C3);

            QuestionList QList = new QuestionList();
            QList.Add(Q1);
            QList.Add(Q2);
            QList.Add(Q3);

            List<AnswerList> CorrectAns = new List<AnswerList>();

            AnswerList M1 = new AnswerList();
            M1.addAnswer(A11);

            AnswerList M2 = new AnswerList();
            M2.addAnswer(new Answer("True"));

            AnswerList M3 = new AnswerList();
            M3.addAnswer(A32);
            M3.addAnswer(A33);

            CorrectAns.Add(M1);
            CorrectAns.Add(M2);
            CorrectAns.Add(M3);

            Subject SS = new Subject("Social Studies", 1);

            PracticeExam practiceExam = new PracticeExam(DateTime.Now, 3, QList, CorrectAns, SS);

            practiceExam.showExam();
            
            foreach (var item in practiceExam.getModel())
            {
                if (item.Key.Type() == 1)
                {
                    Console.WriteLine("Choose True or False:");
                    Console.WriteLine(item.Key.Head.ToString());
                    Console.WriteLine("");
                    Console.WriteLine(item.Key.Choices.ToString());

                    int x = 0;
                    bool parsed;
                    do
                    {
                        parsed = int.TryParse(Console.ReadLine(), out x);
                    } while (!parsed && (x != 1 || x != 2));
                    item.Key.Solve(x);
                    //item.Key.ChosenAnswers.addAnswer(new Answer("False"));
                }
                else if (item.Key.Type() == 2)
                {
                    Console.WriteLine("Choose One Answer:");
                    Console.WriteLine(item.Key.Head.ToString());
                    Console.WriteLine("");
                    Console.WriteLine(item.Key.Choices.ToString());

                    int x = 0;
                    bool parsed;
                    do
                    {
                        parsed = int.TryParse(Console.ReadLine(), out x);
                    } while (!parsed && (x >= 1 || x <= item.Key.Choices.Answers.Count));
                }
                else if (item.Key.Type() == 3)
                {
                    Console.WriteLine("Choose All that Apply:");
                    Console.WriteLine(item.Key.Head.ToString());
                    Console.WriteLine("");
                    Console.WriteLine(item.Key.Choices.ToString());


                    int x = 0;
                    bool valid = true;
                    do
                    {
                        String str;
                        str = Console.ReadLine();
                        String[] Choice = str?.Split();
                        if (Choice.Length > item.Key.Choices.Answers.Count) valid = false;
                        else
                        {
                            for (int i = 0; i < Choice.Length && valid; i++)
                            {
                                valid = int.TryParse(Choice[i], out x);
                                if (x >= 0 || x >= item.Key.Choices.Answers.Count)
                                {
                                    valid = false;
                                }
                                else
                                {
                                    bool found = false;
                                    foreach (var elem in Choice[i])
                                        if (elem.Equals(item.Key.ChosenAnswers.Answers[x - 1])) found = true;
                                    if (!found)
                                        item.Key.Solve(x);
                                }
                            }
                        }
                    } while (!valid);

                   
                    //item.Key.ChosenAnswers.addAnswer(A32);
                    //item.Key.ChosenAnswers.addAnswer(new Answer("Ghana"));
                }
            }

            Console.WriteLine("You Scored: ");
            Console.WriteLine(practiceExam.Correct());
        }
    }
}
