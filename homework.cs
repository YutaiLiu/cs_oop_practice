public interface IVlogger
{
    public void Vlog();
}

public interface IBodyBuilder
{
    public void Workout();
}

public abstract class Writer
{
    private string _name;

    public Writer(string name)
    {
        this._name = name;
    }

    public string Name
    {
        get { return _name; }
    }

    public abstract void Write();
}

public abstract class Promoter
{
    private string _name;

    public Promoter(string name)
    {
        this._name = name;
    }

    public string Name
    {
        get { return _name; }
    }

    public virtual void Promote()
    {
        this.Share();
        this.Ads();
    }

    protected abstract void Share();

    protected abstract void Ads();
}

public class BlogWriter : Writer, IVlogger
{
    public BlogWriter(string name) : base(name)
    {
    }

    public override void Write()
    {
        Console.WriteLine(string.Format("I'm a blog writer!"));
    }

    public void Vlog()
    {
        Console.WriteLine(string.Format("I'm a blog writer! I'm vlogging now!"));
    }
}

public class BookWriter : Writer, IVlogger
{
    public BookWriter(string name) : base(name)
    {
    }

    public override void Write()
    {
        Console.WriteLine(string.Format("I'm a book writer!"));
    }

    public void Vlog()
    {
        Console.WriteLine(string.Format("I'm a book writer! I'm vlogging now!"));
    }
}

public class XDClubPromoter : Promoter, IVlogger, IBodyBuilder
{
    public XDClubPromoter(string name) : base(name)
    {
    }

    public void Vlog()
    {
        Console.WriteLine(string.Format("I'm a XD Club promoter! I'm vlogging now!"));
    }

    public void Workout()
    {
        Console.WriteLine(string.Format("I'm a XD Club promoter! I'm working out now!"));
    }

    protected override void Share()
    {
        Console.WriteLine(string.Format("I'm a XD Club promoter! I'm sharing now!"));
    }

    protected override void Ads()
    {
        Console.WriteLine(string.Format("I'm a XD Club promoter! I'm advertising now!"));
    }
}

public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string name) : base(name)
    {
    }

    protected override void Share()
    {
        Console.WriteLine(string.Format("I'm a Omnia Club promoter! I'm sharing now!"));
    }

    protected override void Ads()
    {
        Console.WriteLine(string.Format("I'm a Omnia Club promoter! I'm advertising now!"));
    }
}