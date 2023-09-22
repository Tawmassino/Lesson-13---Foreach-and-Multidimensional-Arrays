using System.Text;

namespace Lesson_13___Foreach_and_Multidimensional_Arrays
{
    public class Program//reikia pakeisti internal i public, nes darysim testus
    {
        static void Main(string[] args)
        {



            #region userMatrix


            //Console.WriteLine("How many rows?");
            //int row = (Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine("How many columns?");
            //int column = (Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine();

            //int[,] userMatrix = new int[row, column];//nepamirsti jog reikia NEW INT

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.WriteLine("Insert a number");//because the task asks for user input
            //        userMatrix[i, j] = Convert.ToInt32(Console.ReadLine());

            //    }
            //}





            //// DISPLAY - parodyti masyva
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write(userMatrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("end of task");
            //Console.WriteLine("===================================");
            #endregion


            #region WhatIsTheMatrixMethod

            Console.WriteLine("What is the Matrix?");
            int rows = 4;
            int cols = 5;
            int[,] matrix = new int[rows, cols];

            //INITIALIZE - uzpildyti masyva
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = i + j;
                }
            }


            // DISPLAY - parodyti masyva
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            //--------------------
            Console.WriteLine();


            //------------------------------------------------------
            Console.WriteLine("======================================= TASK B =======================================");

            int[,] arrayWow =
            {
                {2, 3, 5},
                {5, 9, 6,},
                {10, 3, 6,},
            };

            MatchFinderIntegerArray(arrayWow);
            Console.WriteLine();
            Console.WriteLine(" ============ End of Task about repeated numbers ============ ");

            //-------------------- animals -------------------

            #region AnimalArrayTask
            //#region animalarray2


            //Console.WriteLine("Animals");

            //Console.WriteLine("How many animals do you know?");
            //int howManyAnimals = Convert.ToInt32(Console.ReadLine());//eilute
            //int animalProperties = 3;//stulpas
            //string[,] animals = new string[howManyAnimals + 1, animalProperties];//+1 nes vienas stulpelis jau rezervuotas NAME TYPE COLOR

            ////initialize the animal array
            //animals[0, 0] = "NAME";
            //animals[0, 1] = "TYPE";
            //animals[0, 2] = "COLOR";

            //Console.WriteLine($"Ok. Answer questions about these {howManyAnimals} animals");

            //for (int i = 1; i <= howManyAnimals; i++)//sukelti i viena loopa, nes stulpeliai nesikeicia
            //{
            //    Console.WriteLine("What is the name of the animal?");
            //    animals[i, 0] = Console.ReadLine();

            //    Console.WriteLine("What is the type of the animal?");
            //    animals[i, 1] = Console.ReadLine();

            //    Console.WriteLine("What is the color of the animal?");
            //    animals[i, 2] = Console.ReadLine();

            //    Console.WriteLine("your animal has been created");
            //}

            //// DISPLAY - parodyti masyva
            //for (int i = 0; i <= howManyAnimals; i++)
            //{
            //    for (int j = 0; j < animalProperties; j++)
            //    {
            //        Console.Write(animals[i, j].PadRight(15));
            //    }
            //    Console.WriteLine();
            //}
            //#endregion
            #endregion

            /*
            #region FirstPart


            Greenerize();
            #region TASK1
            Console.WriteLine("============ BEGINNING OF TASK 1 ============");

            #region average
            double[] array = { 4, 8, 15, 16, 23, 42 };
            double result1A = calculateAverage(array);
            Console.WriteLine($"the average of your array is {result1A}");
            #endregion

            Console.WriteLine();

            #region positive                     
            Console.WriteLine(" ------------ POSITIVENUMBERS ------------");
            RstClr();
            int[] array1B = { 4, -8, 15, -16, 23, -42, 108 };
            int[] result1B = ReturnOnlyPositives(array1B);


            foreach (int smth in result1B)
            {
                Console.WriteLine(smth);
            }

            #endregion


            Console.WriteLine();
            Greenerize();

            #region taxes                     
            Console.WriteLine("------------ GPM ------------"); RstClr();
            double[] array1C = { 222, 404, 555, 666, 777 };
            double[] result1C = CalculateGPMTax(array1C);

            //Console.WriteLine(result1C);
            //Console.WriteLine($"The 15% from {array1C} are");
            foreach (double smth in result1C)
            {
                Console.WriteLine(smth);
            }
            #endregion

            Console.WriteLine();
            Greenerize();

            #region LongWords
            Console.WriteLine("------------ Long Words ------------"); RstClr();
            //Console.WriteLine("Write your motto with long words");
            //var userInputWord = Console.ReadLine();
            //Console.WriteLine(userInputWord);

            string sentencija = "O straigtasparnio pilote kur tu mus vedi?";
            string[] sakiniorezultatas = LongWords(sentencija);//reikia rezultato i kuri ateina metodo darbai!!!

            //Console.WriteLine(sentencija);

            foreach (string smth in sakiniorezultatas)
            {
                Console.WriteLine(smth);
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine("============ END OF TASK 1 ============");
            #endregion


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            #region foreach
            //naudojama lengvai nuskaityti, bet negalima keisti nieko


            string[] autos = new string[] { "BMW", "Audi", "Toyota" };


            Console.WriteLine("------------------------------");
            Console.WriteLine("Printing cars using For Loop");
            for (int i = 0; i < autos.Length; i++) { Console.WriteLine(autos[i]); }

            Console.WriteLine("Printing cars using ForEach Loop");
            foreach (string auto in autos) { Console.WriteLine(auto); }
            #endregion 

            RstClr();
            #endregion
            */


            #region NameSimilar

            string[,] names = new string[4, 3];//stulpeliai, eilutes
            names[0, 0] = "Tomas";
            names[0, 1] = "Laura";
            names[0, 2] = "Virginija";
            names[1, 0] = "Kristijonas";
            names[1, 1] = "Gintare";
            names[1, 2] = "Salomeja";
            names[2, 0] = "Tomas";
            names[2, 1] = "Mantas";
            names[2, 2] = "Laura";
            names[3, 0] = "Martynas";
            names[3, 1] = "Laurynas";
            names[3, 2] = "Milda";

            //{
            //    { "Tomas", "Laura", "Virginija"},
            //{ "Kristijonas", "Gintare", "Salomeja"},
            //{ "Tomas", "Mantas", "Laura"},
            //{ "Martynas", "Laurynas", "Milda"}
            //};

            FindMatchinArray(names);

            #endregion

        }



        //---------------------------------------------------------------------------------------methods ------------------------------------------------------

        //eiti per masyva ir deti visus i nauja masyva
        //jei zodis jau yra buves, tada deti ji i atskira masyva
        //printinti tik ta atskira masyva

        public static void FindMatchinArray(string[,] matrix)
        {
            StringBuilder resultBuilder = new StringBuilder("");//idedame kazka tuscio, kad nebutu null
            //string[] auxArray;//pagalbinis masyvas
            //int positionOfWordInAuxArray = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var current = matrix[i, j];
                    //--------------------------------------------
                    for (int x = 0; x < matrix.GetLength(0); x++)
                    {
                        for (int y = 0; y < matrix.GetLength(1); y++)
                        {
                            if (x != i || y != j) // Avoid comparing with itself
                            {
                                if (current == matrix[x, y] && !resultBuilder.ToString().Contains(current))
                                {
                                    resultBuilder.Append(current);
                                    resultBuilder.Append(" ");
                                    break; // No need to continue searching in this row
                                }

                                //if (current != matrix[i, j])
                                //{
                                //    continue;
                                //}
                                //else if (current == matrix[i, j] && !resultBuilder.ToString().Contains(current))
                                //{
                                //    resultBuilder.Append(current);
                                //    resultBuilder.Append(" ");
                                //}

                            }
                        }


                    }
                }
            }
            // ---- display the new array
            Console.WriteLine(resultBuilder);
        }




        //----



        public static void MatchFinderIntegerArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int current = matrix[i, j];
                    int currentColumnIndex = j + 1;
                    for (int k = i; k < matrix.GetLength(0); k++)//pradedame nuo I .K - eilute
                    {
                        for (int l = currentColumnIndex; l < matrix.GetLength(1); l++)// L - stulpelis. 0 - pirmas stulpelis
                        {
                            if (current == matrix[k, l])
                            {
                                Console.WriteLine("repeated: " + matrix[k, l]);
                            }
                        }
                        currentColumnIndex = 0;
                    }
                }
            }
        }



        public static void ShowTable()
        {
            string[,] table = new string[3, 3];

            //0th index - rows
            //1st index - columns


            //header/categories
            table[0, 0] = "Name";
            table[0, 1] = "Age";
            table[0, 2] = "City";

            table[1, 0] = "John";
            table[1, 1] = "25";
            table[1, 2] = "NYC";

            table[2, 0] = "Jane";
            table[2, 1] = "28";
            table[2, 2] = "London";

            //Display table in console
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write((table[i, j] + "\t"));
                }
                Console.WriteLine();
            }
        }

        public static string[] LongWords(string sakinys)
        {
            string[] SplitSentence = sakinys.Split(" ");
            //char[] sentenceChars = sakinys.Trim().ToCharArray();
            string[] sentenceNew = new string[SplitSentence.Length];

            int index = 0;
            foreach (string word in SplitSentence)
            {
                if (word.Length > 4)
                {
                    sentenceNew[index] = word;
                    index++;
                }
            }

            return sentenceNew;
        }

        public static void Greenerize()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        public static void RstClr()
        {
            Console.ResetColor();
        }

        public static double[] CalculateGPMTax(double[] array)
        {
            double[] masyvas = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                masyvas[i] = array[i] * 0.15;
            }
            return masyvas;
        }

        public static int[] ReturnOnlyPositives(int[] array)
        {
            int[] masyvas = new int[array.Length]; // naujas masyvas susideti reikiamus skaicius
            int lastAddedIndex = 0;           //indexas kiek turim pozityviu skaiciu jau atsirinke i nauja masyva

            foreach (int item in array)
            {
                if (item > 0)
                {
                    masyvas[lastAddedIndex] = item;
                    lastAddedIndex++;
                }
            }
            return masyvas;
        }
        public static double calculateAverage(double[] array)
        {
            double sum = 0;
            foreach (double item in array)
            {
                sum += item;
            }
            return sum / array.Length;
        }
    }
}


