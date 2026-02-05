namespace AgregaceAKompozice
{
public class Trida
{
    public string Nazev { get; } = new ();
    public List<Student> Studenti { get; }

    // KOMPOZICE: třídní kniha vzniká spolu s třídou
    public TridniKniha TridniKniha { get; }

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
        Student.Add(s);
        
    }

    public void OdeberStudenta(Student s)
    {
        // TODO
    }

    public void VypisStudenty()
    {
        // TODO
    }
}
}