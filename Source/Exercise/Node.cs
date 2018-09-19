namespace Exercise
{
    public class Node
    {
        public int Info { get; private set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
	
	    public Node(int i)
	    {
		    Info = i;
	        Left = null;
	        Right = null;
	    }
    }
}
