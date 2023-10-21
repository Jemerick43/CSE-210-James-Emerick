/*
Name: Reference
Purpose:Display reference provided by user
        Store reference in a variable.
        Replace reference with a blank space ('______')
Author: James Emerick
Date:
*/

class Reference
{
        public string StoreReference()
        {
                Console.WriteLine("Please enter the reference of your scripture: ");
                string jeReference = Console.ReadLine();
                return jeReference;
        }

        public bool HiddenReference()
        {
                Console.WriteLine("Enter 1 if you would like to hide the reference: ");
                int jeHidden = int.Parse(Console.ReadLine());
                bool jeIsHidden = false;
                if (jeHidden == 1)
                {
                        jeIsHidden = true;
                }
                else
                {
                        jeIsHidden = false;
                }

                return jeIsHidden;
        }
}