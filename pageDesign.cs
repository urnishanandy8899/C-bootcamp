public abstract class Document
{
public List<Page> DocPages {get; set;}
}

public class MSDoc : Document
{
public MSDoc()
{
DocPages.Add(new Page());
}

}

public class Page
{
public Header PageHeader{get; set;}
public Margin PageMargin{get; set;}
public Footer PageFooter{get; set;}
public List<Paragraph> PageParagraphs {get; set;}
}

public class Header{}

public class Margin{}

public class Footer{}

public class Paragraph{}
public class Program
{
public static void Main()
{
MSDoc msDoc = new MSDoc();
}

}
