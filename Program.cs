internal class Program
{
       static void Main(string[] args)
    {
        int[,] inputs = new int[,] {
            { 8, 3,5,4,1,6,9,2,7 },
            { 2, 9,6,8,5,7,4,3,1 },
            { 4, 1,7,2,9,3,6,5,8 },
            { 5, 6,9,1,3,4,7,8,2 },
            {1, 2,3,6,7,8,5,4,9 },
            { 7, 4,8,5,2,9,1,6,3 },
            { 6, 5,2,7,8,1,3,9,4 },
            { 9, 8,1,3,4,5,2,7,6 },
            { 3, 7,4,9,6,2,8,1,5 } };
      var suduko = new Suduko(inputs);
       Console.WriteLine(suduko[5,5]);
        suduko[5, 5] = -5;
        Console.WriteLine(suduko[5, 5]);
     /*   var ip = new IP("112.114.55.33");
        var firstSegment = ip[0];
        Console.WriteLine( $"IP ADDRESS:{ip.Address}");
        Console.WriteLine($"Fisrt Segment: {firstSegment}");*/
    }
}
public class Suduko
{
    private int[,] _matrix;
    public int this[int row, int col]
    {
        get
        {
            if (row < 0 || row > _matrix.GetLength(0)-1)
                return -1;
            if (col < 0 || col > _matrix.GetLength(1)-1)    
                return -1;
            return _matrix[row, col];
        }
        set
        {
            if (value < 0 || value > _matrix.GetLength(0) - 1)
                return;
           
           
            _matrix[row, col] = value;
        }
    }
    public Suduko (int[,]matrix) {
_matrix= matrix;
}
}
/*public class IP
{
    private int [] segments = new int[4];
    public int this[int index] {
        get
        {
            return segments[index];
        }

        set
        {
            segments[index] = value;
        }
    }
    public IP(string IPAddress)
    {
        var segs = IPAddress.Split(".");
        for(int i=0;i<segs.Length;i++)
        {
            segments[i]=Convert.ToInt32(segs[i]); 
        }
    }
    public IP(int Segment1, int Segment2, int Segment3, int Segment4)
    {
        segments[0] = Segment1;
        segments[1] = Segment2;
        segments[2] = Segment3;
        segments[3] = Segment4;
    }
    public string Address => string.Join(".", segments);
}*/