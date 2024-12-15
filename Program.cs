namespace FinalProjectHT;

class Program
{
static void Main(string[] args)
    {
        Console.WriteLine("----- CIDM2315 Final Project: Haylee Torres -----");
        Console.WriteLine("----- Welcome to Buff Hotel -----");

        User admin = new User("alice", "alice123");

        Console.WriteLine("--> Please input username:");
        string username = Console.ReadLine();
        Console.WriteLine("--> Please input password:");
        string password = Console.ReadLine();

        if (username != admin.Username || password != admin.Password)
        {
            Console.WriteLine("--> Wrong Username/Password");
            return; 
        }

        Console.WriteLine("--> Login Successfully.\n");
        Console.WriteLine($"** Hello User: {username} **");

        List<Room> rooms = new List<Room>
        {
            new Room(101, 2),
            new Room(102, 2),
            new Room(103, 2),
            new Room(104, 2),
            new Room(105, 2),
            new Room(106, 3),
            new Room(107, 3),
            new Room(108, 3),
            new Room(109, 3),
            new Room(110, 4)
        };

        bool loggedOut = false;

        while (!loggedOut)
        {
            Console.WriteLine("***************");
            Console.WriteLine("--> Please Select:");
            Console.WriteLine("1. Show Available Room");
            Console.WriteLine("2. Check-In");
            Console.WriteLine("3. Show Reserved Room");
            Console.WriteLine("4. Check-Out");
            Console.WriteLine("5. Log Out");
            Console.WriteLine("***************");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowAvailableRooms(rooms); 
                    break;

                case "2":
                    CheckIn(rooms); 
                    break;

                case "3":
                    ShowReservedRooms(rooms); 
                    break;

                case "4":
                    CheckOut(rooms); 
                    break;

                case "5":
                    loggedOut = true; 
                    Console.WriteLine("-->Log out system");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ShowAvailableRooms(List<Room> rooms)
    {
        int availableCount = 0;
        foreach (Room room in rooms)
        {
            if (!room.IsReserved)
            {
                Console.WriteLine($"+ Room number {room.RoomNumber}; Capacity: {room.Capacity}");
                availableCount++;
            }
        }
        Console.WriteLine($"------ Number of Available Rooms: {availableCount} ------");
    }

    static void CheckIn(List<Room> rooms)
    {
        Console.WriteLine("--> Input Number of People:");
        if (!int.TryParse(Console.ReadLine(), out int numPeople) || numPeople <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            return;
        }

        bool roomFound = false;

        foreach (Room room in rooms)
        {
            if (!room.IsReserved && room.Capacity >= numPeople)
            {
                Console.WriteLine($"+ Room number {room.RoomNumber}; Capacity: {room.Capacity}");
                roomFound = true;
            }
        }
    
        if (!roomFound)
        {
            Console.WriteLine("------Number of Available Rooms: 0------");
            Console.WriteLine("--> No suitable room at this time.");
            return;
        }

         int availableRoomsCount = rooms.Count(room => !room.IsReserved && room.Capacity >= numPeople);
         Console.WriteLine($"------ Number of Available Rooms: {availableRoomsCount} ------");

        Console.WriteLine("--> Input Room Number:");
        if (!int.TryParse(Console.ReadLine(), out int selectedRoomNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid room number.");
            return;
        }

        foreach (Room room in rooms)
        {
            if (!room.IsReserved && room.Capacity >= numPeople && room.RoomNumber == selectedRoomNumber)
            {
                Console.WriteLine("Input Customer name:");
                room.CustomerName = Console.ReadLine();
                Console.WriteLine("Enter Customer email:");
                room.CustomerEmail = Console.ReadLine();
                room.IsReserved = true; 
                Console.WriteLine($"--> Check-In successfully! Customer is assigned to room {room.RoomNumber}");
                return;
            }
        }

         Console.WriteLine("Invalid input. Please enter a valid room number.");
    }

    static void ShowReservedRooms(List<Room> rooms)
    {
        Console.WriteLine("\n-------Reserved Room-------");
        foreach (Room room in rooms)
        {
            if (room.IsReserved)
            {
                Console.WriteLine($"+ Room {room.RoomNumber}; Customer: {room.CustomerName};");
            }
        }
    }

    static void CheckOut(List<Room> rooms)
    {
        Console.WriteLine("\nEnter room number to check-out:");
        if (!int.TryParse(Console.ReadLine(), out int roomNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid room number.");
            return;
        }

        bool roomFound = false;

        foreach (Room room in rooms)
        {
            if (room.RoomNumber == roomNumber && room.IsReserved)
            {
                Console.WriteLine($"--> Room: {room.RoomNumber}; Customer Name: {room.CustomerName}");
                Console.WriteLine("--> Please confirm the customer name and input y to continue Check-Out OR input any key to cancel.");
                string confirmation = Console.ReadLine();

                if (confirmation.ToLower() == "y")
                {
                    room.IsReserved = false; 
                    room.CustomerName = string.Empty;
                    room.CustomerEmail = string.Empty;
                    Console.WriteLine("Check-Out Successfully!");
                    ShowReservedRooms(rooms);
                }
                else
                {
                    Console.WriteLine("Cancel Check-Out");
                }

                roomFound = true;
                break;
            }
        }

        if (!roomFound)
        {
            Console.WriteLine("--> Could not find customer record of this room");
        }
    }
}

