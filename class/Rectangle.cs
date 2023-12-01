

namespace rectangle;
public class Rectangle : IComparable<Rectangle>
{
    string fillColour;
    string outlineColour;
    float side1length;
    float side2length;
    public string FillColour { get => fillColour; set => fillColour = value; }
    public string OutlineColour { get => outlineColour; set => outlineColour = value; }
    public float Side1length { get => side1length; set => side1length = value; }
    public float Side2length { get => side2length; set => side2length = value; }
    public Rectangle(string fillColour, string outlineColour, float side1length, float side2length) 
    {
    this.fillColour = fillColour;
    this.outlineColour = outlineColour;
    this.side1length = side1length;
    this.side2length = side2length;
    }
    public float Square() { return side1length * side2length; }
    public float Perimeter() {return side1length*2 + side2length*2;}
    public int CompareTo(Rectangle? other)
    {
        return this.Square().CompareTo(other?.Square());
    }
    public override string ToString() =>
        "Fill colour: " + fillColour +
        ", Outline colour: " + outlineColour +
        ", First length: " + side1length +
        ", Second length: " + side2length;

}
