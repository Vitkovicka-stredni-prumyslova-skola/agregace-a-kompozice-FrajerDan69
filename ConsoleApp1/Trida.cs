namespace AgregaceAKompozice
{
public class Trida
{
    public string Nazev { get; }
    public List<Student> Studenti { get; }

    // KOMPOZICE: třídní kniha vzniká spolu s třídou
    public TridniKniha TridniKniha { get; } = new ();

    public Trida(string nazev)
    {
        if(string.IsNullOrWhiteSpace(nazev))
                    throw new ArgumentException("Název třídy nesmí být prázdný");

        Nazev = nazev.Trim();
        
        TridniKniha = new TridniKniha();
    }

    // AGREGACE: student existuje i bez třídy
    public void PridejStudenta(Student s)
    {
        if(s == null) throw new ArgumentNullException(nameof(s));

        if(Studenti.Contains(s))
            throw new InvalidOperationException("Student již je ve třídě zapsán");

            if(s == null) throw new ArgumentNullException(nameof(s));
        
        if(!Studenti.Contains(s))
            throw new InvalidOperationException("Student není ve třídě zapsán");

        Studenti.Add(s);
        
    }

    public void OdeberStudenta(Student s)
    {
        Studenti.Remove(s);
    }

    public void VypisStudenty()
    {
        Console.WriteLine($"Třída: {Nazev}");

        for(int i = 0;i < Studenti.Count; i++)
        {
            Console.WriteLine($"{i+ 1}. {Studenti[i]}");
        }
    }
}
}