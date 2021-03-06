using System;

class Shape
{
    ///<summary>Throws an NotImplementedException with the message Area() is not implemented</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    ///wide boi
    private int width;
    ///tall boi
    private int height;

    ///<summary>how wide is da boi</summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    
    ///<summary>how tall is da boi</summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

    ///<summary>oh he a big boi</summary>
    public new int Area()
    {
        return (this.Height * this.Width);
    }

    ///<summary>what is da boi?</summary>
    public override string ToString()
    {
        return ($"[Rectangle] {this.Width} / {this.Height}");
    }
}

class Square : Rectangle
{
    ///S Q U A R E
    private int size;
    ///<summary> B E H O L D I T S G L O R Y </summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                this.size = value;
                this.Height = value;
                this.Width = value;
            }
        }
    }

    ///<summary> B A S K I N I T S B R I L L I A N C E </summary>
    public override string ToString()
    {
        return ($"[Square] {this.Width} / {this.Height}");
    }
}
