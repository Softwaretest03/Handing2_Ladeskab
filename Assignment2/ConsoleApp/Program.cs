﻿

class Program
{
    static void Main(string[] args)
    {
        // Assemble your system here from all the classes

        bool finish = false;
        do
        {
            Library.IDoor door = new Library.Door();

            string input;
            System.Console.WriteLine("Indtast E, O, C, R: ");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) continue;

            switch (input[0])
            {
                case 'E':
                    finish = true;
                    break;

                case 'O':
                    door.LockDoor();
                    //door.OnDoorOpen();
                    break;

                case 'C':
                    door.UnlockDoor();  
                    //door.OnDoorClose();
                    break;

                case 'R':
                    System.Console.WriteLine("Indtast RFID id: ");
                    string idString = System.Console.ReadLine();

                    int id = Convert.ToInt32(idString);
                    //rfidReader.OnRfidRead(id);
                    break;

                default:
                    break;
            }

        } while (!finish);
    }
}