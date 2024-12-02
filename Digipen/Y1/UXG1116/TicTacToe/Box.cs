class Box
{
    // Game UI
    private string[][] ui;
    private string[] odd = { "-", "-", "-", "-", "-" };

    // Initialize Coordinates List
    List<Coordinate> coordinates = new List<Coordinate>();
    Coordinate one = new Coordinate("1", 0, 0);
    Coordinate two = new Coordinate("2", 0, 2);
    Coordinate three = new Coordinate("3", 0, 4);
    Coordinate four = new Coordinate("4", 2, 0);
    Coordinate five = new Coordinate("5", 2, 2);
    Coordinate six = new Coordinate("6", 2, 4);
    Coordinate seven = new Coordinate("7", 4, 0);
    Coordinate eight = new Coordinate("8", 4, 2);
    Coordinate nine = new Coordinate("9", 4, 4);

    // Initialise UI
    public Box()
    {
        // Add UI Components
        ui = new string[5][];
        for (int i = 0; i < ui.Length; i++)
        {
            ui[i] = i % 2 == 0 ? new string[] { "-", "|", "-", "|", "-" } : odd;
        }

        // Add coordinates to coords list
        coordinates.Add(one);
        coordinates.Add(two);
        coordinates.Add(three);
        coordinates.Add(four);
        coordinates.Add(five);
        coordinates.Add(six);
        coordinates.Add(seven);
        coordinates.Add(eight);
        coordinates.Add(nine);

        // Sub in Coordinates to UI
        for (int i = 0; i < coordinates.Count; i++)
        {
            ui[coordinates[i].GetX()][coordinates[i].GetY()] = coordinates[i].GetValue();
        }
    }

    // Player input function
    public bool Input(string s, Player CurrentPlayer)
    {
        // Convert string to int
        if (!Int32.TryParse(s, out int result))
        {
            return false;
        }

        // Check if input valid
        if (s.Length != 1 || result < 0 || result > 9)
        {
            Console.WriteLine("Input: 1 - 9");
            return false;
        }

        // Create index value to substitute
        int index = result - 1;

        // Add Player action to array
        // ui[coordinates[index].GetX()][coordinates[index].GetY()] = CurrentPlayer.GetAction();
        coordinates[index].SetValue(CurrentPlayer.GetAction());
        return true;
    }

    // Draw UI
    public void Draw()
    {
        for (int i = 0; i < coordinates.Count; i++)
        {
            ui[coordinates[i].GetX()][coordinates[i].GetY()] = coordinates[i].GetValue();
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(ui[i][j]);
            }
            Console.WriteLine();
        }
    }

    public bool CheckWin()
    {
        if (ui[0][0] == ui[0][2] && ui[0][0] == ui[0][4])
        {
            return true;
        }
        else if (ui[2][0] == ui[2][2] && ui[2][0] == ui[2][4])
        {
            return true;
        }
        else if (ui[4][0] == ui[4][2] && ui[4][0] == ui[4][4])
        {
            return true;
        }
        else if (ui[0][0] == ui[2][0] && ui[0][0] == ui[4][0])
        {
            return true;
        }
        else if (ui[0][2] == ui[2][2] && ui[0][2] == ui[4][2])
        {
            return true;
        }
        else if (ui[0][4] == ui[2][4] && ui[0][4] == ui[4][4])
        {
            return true;
        }
        else if (ui[0][0] == ui[2][2] && ui[0][0] == ui[4][4])
        {
            return true;
        }
        else if (ui[0][4] == ui[2][2] && ui[0][4] == ui[4][0])
        {
            return true;
        }
        return false;
    }

    public bool CheckDraw()
    {
        foreach (Coordinate coords in coordinates)
        {
            bool notnumber = Int32.TryParse(coords.GetValue(), out int value);

            if (notnumber)
            {
                return false;
            }
        }
        return true;
    }
}
