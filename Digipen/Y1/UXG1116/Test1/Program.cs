using System;
using System.Collections.Generic;


partial class Program
{
    static List<MonoBehaviour> monoBehaviours = new List<MonoBehaviour>();

    static void AddMonoBehaviour(Vector2 position, string name)
    {
        Console.WriteLine("Adding: {0}", name);
        MonoBehaviour mb = new MonoBehaviour(position, name);
        monoBehaviours.Add(mb);
    }

    static void EnableMonoBehaviourByName(string name)
    {
        // We can now use foreach!
        Console.WriteLine("Enabling: {0}", name);
        foreach (MonoBehaviour mono in monoBehaviours)
        {
            if (mono.name.Equals(name))
            {
                mono.enabled = true;
                break;
            }
        }
    }

    static void DisableMonoBehaviourByName(string name)
    {
        Console.WriteLine("Disabling: {0}", name);    
        foreach (MonoBehaviour mono in monoBehaviours)
        {
            if (mono.name.Equals(name))
            {
                mono.enabled = false;
                break;
            }
        }
    }

    static void PrintActiveMonoBehaviours()
    {
        foreach (MonoBehaviour mono in monoBehaviours)
        {
            if (mono.enabled)
            {
                mono.Print();
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Testing if Vector2 is struct ===");
        Vector2 vec1 = new Vector2(1, 2);
        Vector2 vec2 = vec1;
        vec2.x = 3;
        vec2.y = 4;
        Console.WriteLine("vec1: ({0} {1}) should be different from vec2: ({2} {3})", vec1.x, vec1.y, vec2.x, vec2.y);
        
        Console.WriteLine("===    Testing Vector2 ===");
        for (int i = 0; i < 5; ++i) {
            for(int j = 0; j < 5; ++j)
            {
                Vector2 vec = new Vector2((float)i, (float)j);
                Console.WriteLine("{0},{1}", vec.x, vec.y);
            }
        }
        
        Console.WriteLine("=== Testing if MonoBehaviour is class ===");
        MonoBehaviour mono1 = new MonoBehaviour(new Vector2(0,0), "Gerald");
        MonoBehaviour mono2 = mono1;
        mono2.name = "Kevin";
        Console.WriteLine("mono1: ({0}) should be same as mono2: ({1})", mono1.name, mono2.name);
        
        Console.WriteLine("=== Testing constructedCount ===");
        AddMonoBehaviour(new Vector2(10.0f, 10.0f), "Gerald");
        AddMonoBehaviour(new Vector2(20.0f, 20.0f), "Elie");
        AddMonoBehaviour(new Vector2(-100.0f, 20.0f), "Alwyn");
        AddMonoBehaviour(new Vector2(-250.0f, -230.0f), "Kevin");
        Console.WriteLine("Total number of MonoBehaviour constructed: {0}", MonoBehaviour.GetConstructedCount());
        AddMonoBehaviour(new Vector2(10.0f, 10.0f), "Gerald2");
        AddMonoBehaviour(new Vector2(20.0f, 20.0f), "Elie2");
        AddMonoBehaviour(new Vector2(-100.0f, 20.0f), "Alwyn2");
        Console.WriteLine("Total number of MonoBehaviour constructed: {0}", MonoBehaviour.GetConstructedCount());
		monoBehaviours.Clear();
        
        Console.WriteLine("=== Testing MonoBehavior ===");
        AddMonoBehaviour(new Vector2(10.0f, 10.0f), "Gerald");
        AddMonoBehaviour(new Vector2(20.0f, 20.0f), "Elie");
        AddMonoBehaviour(new Vector2(-100.0f, 20.0f), "Alwyn");
        AddMonoBehaviour(new Vector2(-250.0f, -230.0f), "Kevin");
        PrintActiveMonoBehaviours();
        
        DisableMonoBehaviourByName("Kevin");
        PrintActiveMonoBehaviours();
        DisableMonoBehaviourByName("Gerald");
        PrintActiveMonoBehaviours();
        EnableMonoBehaviourByName("Gerald");
        PrintActiveMonoBehaviours();
    }


}

