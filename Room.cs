class Room
{
    public int RoomNumber { get; }
    public int Capacity { get; }
    public bool IsReserved { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }

    public Room(int roomNumber, int capacity)
    {
        RoomNumber = roomNumber;
        Capacity = capacity;
        IsReserved = false;
        CustomerName = string.Empty;
        CustomerEmail = string.Empty;
    }
}