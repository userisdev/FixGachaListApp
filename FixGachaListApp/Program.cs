var input = args.FirstOrDefault();
if (!File.Exists(input))
{
    Console.WriteLine("not found.");
    Environment.Exit(1);
}

File.WriteAllLines(input, 
    File.ReadAllLines(input)
        .Select(e => e.Split(','))
        .Select(s=> (s[0], s[1], s[3]))
        .Select(t => $"{t.Item1},{t.Item2},{t.Item3}"));
